﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRTemplate.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessageToGroup(string groupName, string message)
        {
            // TODO: Maybe color-code/style the group name, connection id and message differently.
            return Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} ({groupName}): {message}");
        }

        public async Task AddToGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string groupName)
        {
            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} is leaving the group {groupName}.");

            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        }
    }
}
