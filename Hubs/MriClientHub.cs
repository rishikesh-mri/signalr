using Microsoft.AspNetCore.SignalR;

namespace signalr.Hubs
{
    public class MriClientHub : Hub
    {
        public async Task AddToGroup(string clientId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, clientId);
        }
    }
}
