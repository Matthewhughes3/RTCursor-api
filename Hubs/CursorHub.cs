using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace api.Hubs
{
    public class CursorHub : Hub
    {
        public async Task SendCursor(Cursor cursor)
        {
            await Clients.Others.SendAsync("receiveCursor", Context.ConnectionId, cursor);
        }
        public class Cursor
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}