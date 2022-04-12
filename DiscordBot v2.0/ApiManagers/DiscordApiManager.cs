using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    public class DiscordApiManager
    {
        ISocketMessageChannel adminChannel;

        public async Task SendAdminMessage(string text)
        {
            if (adminChannel == null)
            {
                return;
            }

            await adminChannel.SendMessageAsync(text);
        }

        public async Task SetAdminChannel(ISocketMessageChannel adminChannel)
        {
            this.adminChannel = adminChannel;
        }
    }
}
