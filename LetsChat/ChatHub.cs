using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;


namespace LetsChat
{
    [Authorize]
    public class ChatHub : Hub
    {
        private IUserTracker<ChatHub> userTracker;

        public ChatHub(IUserTracker<ChatHub> userTracker)            
        {
            this.userTracker = userTracker;
        }

        public override async Task OnConnectedAsync()
        {
            var user = Helper.GetUserInformationFromContext(Context);
            await this.userTracker.AddUserAsync(Context.Connection, user);
            await Clients.All.InvokeAsync("UsersJoined", new UserInformation[] { user });
            //// On connection, refresh online list.
            await Clients.All.InvokeAsync("SetUsersOnline", await GetOnlineUsersAsync());
           
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var user = Helper.GetUserInformationFromContext(Context);
            await Clients.All.InvokeAsync("UsersLeft", new UserInformation[] { user });
            await this.userTracker.RemoveUserAsync(Context.Connection);
            //// On disconnection, refresh online list.
            await Clients.All.InvokeAsync("SetUsersOnline", await GetOnlineUsersAsync());
            await base.OnDisconnectedAsync(exception);
        }
       
        public async Task Send(string message)
        {
            UserInformation user = Helper.GetUserInformationFromContext(Context);
            await Clients.All.InvokeAsync("Send", user.Name, message, user.ImageUrl);
        }

        public async Task<IEnumerable<UserInformation>> GetOnlineUsersAsync()
        {
            return await userTracker.GetAllOnlineUsersAsync();
        }
    }
}
