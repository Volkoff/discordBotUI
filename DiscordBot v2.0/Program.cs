using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Discord;
using Discord.Net;
using Discord.WebSocket;
namespace DiscordBot_v2._0

{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        private DiscordSocketClient _client;
        UIDataUserInput _data;
        //logging into program
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        public async Task MainAsync(UIDataUserInput uIData,TelegramApiManager telegramApiManager, DiscordApiManager discordApiManager)
        {
            _data = uIData;
            _client = new DiscordSocketClient();
            _client.MessageReceived += new DiscordCommandHandler(_data,telegramApiManager,discordApiManager).HandleCommand;
            _client.Log += Log;
            var token = File.ReadAllText("token.txt");
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);
        }
        
    }
}