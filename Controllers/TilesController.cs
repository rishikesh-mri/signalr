using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using signalr.Hubs;

namespace signalr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TilesController : ControllerBase
    {
        private readonly IHubContext<UserHub> _userHubContext;

        public TilesController(IHubContext<UserHub> userHubContext)
        {
            _userHubContext = userHubContext;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTiles(string user, string clientId)
        {
            await _userHubContext.Clients.Group($"{clientId}-{user}").SendAsync("UpdateTiles");
            return Ok();
        }
    }
}
