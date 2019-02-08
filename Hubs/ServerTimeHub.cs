using Microsoft.AspNetCore.SignalR;
using SignalRTemplate.Services;

namespace SignalRTemplate.Hubs
{
    public class ServerTimeHub : Hub<IClock>
    {
    }
}