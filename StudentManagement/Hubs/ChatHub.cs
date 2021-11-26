using Microsoft.AspNetCore.SignalR;
using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) => await Clients.All.SendAsync("SendMessages", message);
    }
}
