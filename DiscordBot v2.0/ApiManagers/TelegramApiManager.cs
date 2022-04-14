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
        DiscordApiManager discordApiManager;
        TelegramBotClient _client;
        CancellationTokenSource cts;
        TimeSpan ts = new TimeSpan(30000000);
        public TelegramApiManager(string apiKey,DiscordApiManager discordApiManager)
        {
            this.discordApiManager = discordApiManager;
            this._client = new TelegramBotClient(apiKey);
            this.cts = new CancellationTokenSource();
            //var me = await botClient.GetMeAsync();
            ListenToMessages();
        }
        private async void ListenToMessages()
        {
            int updateCount = 0; 
            while (true)
            {
                var updateTask = _client.GetUpdatesAsync(cancellationToken: cts.Token);
                await updateTask.WaitAsync(ts);
                Update[] result = updateTask.Result;
                if (result.Length > updateCount)
                {
                    TelegramCommandHandler telegramCommandHandler = new TelegramCommandHandler(discordApiManager);
                    telegramCommandHandler.HandleMessage(result[updateCount].Message);
                    updateCount++;
                }
            }
        }
       /// <summary>
       /// sending error reports 
       /// </summary>
       /// <param name="message"></param>
       /// <returns></returns>
        public async Task SendSimpleMessage(string message)
        {
            await SendMessage(_client, cts.Token, message);
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
