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
        /// Setting up the telegram bot
        /// </summary>
        /// <param name="message">Message sent to the bot</param>
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

         async Task ReceiveMessage(ITelegramBotClient botClient, CancellationToken cancellationToken, Update update)
        {
            // Only process Message updates: https://core.telegram.org/bots/api#message
            if (update.Type != UpdateType.Message)
                return;
            // Only process text messages
            if (update.Message!.Type != MessageType.Text)
                return;

            var chatId = update.Message.Chat.Id;
            var messageText = update.Message.Text;

            Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

            // Echo received message text
            Telegram.Bot.Types.Message sentMessage = await botClient.SendTextMessageAsync(
                chatId: 1055912231,
                text: "You said:\n" + messageText,
                cancellationToken: cancellationToken);
        }
    }
    }
