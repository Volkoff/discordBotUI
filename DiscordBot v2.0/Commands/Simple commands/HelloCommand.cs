using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class HelloCommand : DiscordCommand
    {
        public override async Task MessageReply(SocketMessage message)
        {
            var emojiHello = new Emoji("✌️");
            await message.AddReactionAsync(emojiHello);
            await message.Channel.SendMessageAsync($@"whaddup fam {message.Author.Mention}");
        }
    }
}
