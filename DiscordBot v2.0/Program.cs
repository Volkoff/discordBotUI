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

        //logging into program
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            _client.MessageReceived += commandHand;
            _client.Log += Log;
            var token = File.ReadAllText("token.txt");
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            await Task.Delay(-1);
        }
        private async Task commandHand(SocketMessage message)
        {
            if (message.Author.IsBot ||
                !message.Content.StartsWith('!'))
            {
                return;
            }
            TelegramApiManager telegram = new TelegramApiManager();
            var emojiConfirmed = new Emoji("✔️");
            await telegram.BotHandler(message.Author + ": " + message.Content);
            string[] commands = message.Content.Split(" ");
            var emojiError = new Emoji("❌");
            string commandString = commands[0]
                .Substring(1)
                .ToLower();
            Command command = null;
            YouTubeApiManager youtube = new YouTubeApiManager();
            TwitchApiManager twitch = new TwitchApiManager();
            SpotifyApiManager spotify = new SpotifyApiManager();


            switch (commandString)
            {
                case "hello":
                    command = new HelloCommand();
                    break;
                //YouTube popular videos in region, look into YtPopsCommand and YouTubeApiManager for more information
                case "ytpops":
                    try
                    {
                        await message.AddReactionAsync(emojiConfirmed);
                        command = new YtPopsCommand(youtube, commands[1]);
                    }
                    catch (Exception ex)
                    {

                        await message.AddReactionAsync(emojiError);
                        await message.Channel.SendMessageAsync(
                            "Invalid command use! Try using this: !ytpops (Code region)");
                        await telegram.BotHandler(ex.ToString());
                        await message.Channel.SendFileAsync(
                            "region_codes.csv");
                    }
                    break;
                //video details of the video, look into VideoDetailsCommand and YouTubeApiManager for more information
                case "videodetails":
                    try
                    {
                        await message.AddReactionAsync(emojiConfirmed);
                        string[] link = commands[1].Split("=");
                        command = new VideoDetailsCommand(youtube, link[1]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        await message.AddReactionAsync(emojiError);
                        await telegram.BotHandler("Invalid url provided");
                        await telegram.BotHandler(ex.ToString());
                        await message.Channel.SendMessageAsync("Invalid url, sorry mate!");
                    }
                    break;
                //YouTube channel information, look into ChannelInfoCommand and YouTubeApiManager for more information
                case "channelinfo":
                    try
                    {
                        await message.AddReactionAsync(emojiConfirmed);
                        string[] channelLink = commands[1].Split('/');
                        command = new ChannelInfoCommand(youtube, channelLink[4]);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        await message.AddReactionAsync(emojiError);
                        await telegram.BotHandler("Invalid url provided");
                        await telegram.BotHandler(ex.ToString());
                        await message.Channel.SendMessageAsync("Invalid url, sorry mate!");
                    }
                    break;
                //Twitch channel information, look into TwitchGetChannelInfo and TwitchApiManager for more information
                case "twitchchan":
                    try
                    {
                        string[] linkChop = commands[1].Split('/');
                        List<string> chopList = new List<string>();
                        chopList.Add(linkChop[3]);
                        command = new TwitchGetChannelInfo(twitch, chopList);
                    }
                    catch (Exception ex)
                    {
                        await message.AddReactionAsync(emojiError);
                        await telegram.BotHandler("Invalid url provided");
                        await telegram.BotHandler(ex.ToString());
                        await message.Channel.SendMessageAsync("Invalid url, sorry mate!");
                    }
                    break;
                //Getting top twitch streamed games right now, look into GetTopGamesCommand and TwitchApiManager for more information
                case "twitchgames":
                    command = new GetTopGamesCommand(twitch);
                    break;
                //Not implemented, do not use
                case "findsong":
                    command = new FindSongOnSpotifyCommand(spotify, commands[1]);
                    break;
                //Streams looked up by a game name, look into TwitchApiManager and GetStreamsByNameCommand for more information
                case "streamsbyname":
                    List<string> name = new List<string>();
                    try
                    {
                        if (commands.Length > 1)
                        {
                            List<string> nameString = new List<string>();
                            for (int i = 1; i < commands.Length; i++)
                            {
                                nameString.Add(commands[i]);
                            }

                            char delim = ' ';
                            string nameStringString = String.Join(delim, nameString);
                            Console.WriteLine(nameStringString);
                            name.Add(nameStringString);
                        }
                        else
                        {
                            name.Add(commands[1]);
                        }

                        command = new GetStreamsByNameCommand(twitch, name);

                    }
                    catch (IndexOutOfRangeException e)
                    {
                        await message.Channel.SendMessageAsync(
                            "Invalid use of command! Try using !streamsbyname (GAME NAME HERE)");
                        await telegram.BotHandler("No game name provided");
                        await telegram.BotHandler(e.ToString());
                    }
                    break;
                //TODO   
                case "playlist":
                    await spotify.Something(message);
                    break;
                //help command to output any command put to use 
                case "help":
                    command = new HelpCommand();
                    break;

            }
            if (command != null)
            {
                await command.MessageReply(message);
            }

        }
    }
}