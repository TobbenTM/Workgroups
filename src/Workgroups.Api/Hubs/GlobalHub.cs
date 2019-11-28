using Microsoft.AspNetCore.SignalR;

namespace Workgroups.Api.Hubs
{
    public class GlobalHub : Hub<IGlobalHubClient>
    {
    }
}
