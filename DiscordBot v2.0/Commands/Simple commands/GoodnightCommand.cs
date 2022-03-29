using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class GoodnightCommand : Command
    {
        public override async Task MessageReply(SocketMessage message)
        {
            await message.Channel.SendMessageAsync($@"goodnight fam {message.Author.Mention}");
        }
    }
}
