using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class SetAdminChannelCommand : DiscordCommand
    {
        DiscordApiManager apiManager;
        public SetAdminChannelCommand(DiscordApiManager discordApiManager)
        {
            this.apiManager = discordApiManager;
        }

        public override async Task MessageReply(SocketMessage message)
        {
            await apiManager.SetAdminChannel(message.Channel);
        }
    }
}
