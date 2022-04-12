using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class SendMessageToChannelCommand : TelegramCommand
    {
        DiscordApiManager discordApiManager;
        public SendMessageToChannelCommand(DiscordApiManager discordApiManager)
        {
            this.discordApiManager = discordApiManager;
        }

        public override async Task MessageReply(Telegram.Bot.Types.Message message)
        {
            string messageText = message.Text; //!global <text to print>
            string textToSend = messageText.Replace("!global ", ""); //<text to print>
            await discordApiManager.SendAdminMessage(textToSend);
        }
    }
}
