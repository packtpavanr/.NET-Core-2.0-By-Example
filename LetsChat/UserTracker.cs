using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;

namespace LetsChat
{
    public class UserTracker<T> : IUserTracker<T>
    {
        private readonly ConcurrentDictionary<HubConnectionContext, UserInformation> onlineUserStore = new ConcurrentDictionary<HubConnectionContext, UserInformation>();

        public async Task AddUserAsync(HubConnectionContext connection, UserInformation userInfo)
        {
            onlineUserStore.TryAdd(connection, userInfo);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<UserInformation>> GetAllOnlineUsersAsync() => await Task.FromResult(onlineUserStore.Values.AsEnumerable());

        public async Task RemoveUserAsync(HubConnectionContext connection)
        {
            if (onlineUserStore.TryRemove(connection, out var userInfo))
            {
                await Task.CompletedTask;
            }
        }
    }
}
