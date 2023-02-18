using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography.Xml;

namespace BlazorChatSignalR.Server.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await SendMessage("", "User connected!");
            await base.OnConnectedAsync();
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("GetThatMessageDude", user, message);
        }
    }
}

