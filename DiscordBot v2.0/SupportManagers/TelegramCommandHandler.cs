using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class TelegramCommandHandler 
    {
        TelegramApiManager telegram;
        DiscordApiManager discordApiManager;

        public TelegramCommandHandler(DiscordApiManager discordApiManager)
        {
            this.discordApiManager = discordApiManager;
        }
        public async void HandleMessage(Telegram.Bot.Types.Message message)
        {

            string text = message.Text;

            if (string.IsNullOrEmpty(text) || !text.StartsWith("!"))
            {
                return;
            }

            string[] commands = text.Split(" ");
            string commandString = commands[0]
                .Substring(1)
                .ToLower();

            TelegramCommand command = null;

            switch (commandString)
            {
                case "global":
                    command = new SendMessageToChannelCommand(discordApiManager);
                    break;
                case "help":
                    break;
            }
            await command?.MessageReply(message);
        }

    }
}
