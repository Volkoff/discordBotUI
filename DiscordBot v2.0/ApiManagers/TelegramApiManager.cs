using Telegram.Bot;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace DiscordBot_v2._0
{
    public class TelegramApiManager
    {
        /// <summary>
        /// Setting up the telegram bot
        /// </summary>
        /// <param name="message">Message sent to the bot</param>
        /// <returns></returns>
        public async Task BotHandler(string message)
        {
            var botClient = new TelegramBotClient("5251072349:AAGdcgDDwPncF86wNI4nbrwvlAAfQ20ZXks");

            using var cts = new CancellationTokenSource();
            await SendMessage(botClient, cts.Token, message);
            var me = await botClient.GetMeAsync();

        }
        /// <summary>
        /// Logging logic
        /// </summary>
        /// <param name="botClient">BotClient logic</param>
        /// <param name="cancellationToken">Cancellation token if something is wrong</param>
        /// <param name="message">Message sent to the bot</param>
        /// <returns></returns>
        async Task SendMessage(ITelegramBotClient botClient, CancellationToken cancellationToken, string message)
        {
            Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: 1055912231,
                text: message,
                cancellationToken: cancellationToken);
        }
    }
}