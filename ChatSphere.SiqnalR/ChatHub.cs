using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSphere.SiqnalR
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message, string chatRoom)
        {
            await Clients.Group(chatRoom).SendAsync("Receive Message", user, message);
        }

        public async Task JoinRoom(string chatRoom)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, chatRoom);
            await Clients.Group(chatRoom).SendAsync("UserJoined", Context.ConnectionId);

        }
    }
}
