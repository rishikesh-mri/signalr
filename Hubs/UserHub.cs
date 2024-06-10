using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace signalr.Hubs
{
    public class UserHub : Hub
    {
        public async Task UpdateTiles(string user, string clientId)
        {
            await Clients.User(user).SendAsync("UpdateTiles");
        }

        public async Task Subscribe(string user, string clientId)
            => await Groups.AddToGroupAsync(Context.ConnectionId, $"{clientId}-{user}");
    }
}
