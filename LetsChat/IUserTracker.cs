using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LetsChat
{
    public interface IUserTracker<T>
    {
        Task<IEnumerable<UserInformation>> GetAllOnlineUsersAsync();
       
        Task AddUserAsync(HubConnectionContext connection, UserInformation userInfo);

        Task RemoveUserAsync(HubConnectionContext connection);
    }
}