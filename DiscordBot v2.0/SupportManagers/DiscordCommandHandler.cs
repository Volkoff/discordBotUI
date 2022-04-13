using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class DiscordCommandHandler
    {
        UIDataUserInput data;
        TelegramApiManager telegram;
        DiscordApiManager DiscordApiManager;
        public DiscordCommandHandler(UIDataUserInput data,TelegramApiManager telegramApiManager,DiscordApiManager discordApiManager)
        {
            this.data = data;
            this.telegram = telegramApiManager;
            this.DiscordApiManager = discordApiManager;
        }
        
        public async Task HandleCommand(SocketMessage message)
        {
            if (
                !message.Content.StartsWith('!'))
            {
                return;
            }

            var emojiConfirmed = new Emoji("✔️");
            await telegram.SendSimpleMessage(message.Author + ": " + message.Content);
            string[] commands = message.Content.Split(" ");
            var emojiError = new Emoji("❌");
            string commandString = commands[0]
                .Substring(1)
                .ToLower();
            DiscordCommand command = null;
            YouTubeApiManager youtube = new YouTubeApiManager(data.YouTubeApiKey);
            TwitchApiManager twitch = new TwitchApiManager(data.TwitchClientID, data.TwitchAccessToken);
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
                        await telegram.SendSimpleMessage(ex.ToString());
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
                        await telegram.SendSimpleMessage("Invalid url provided");
                        await telegram.SendSimpleMessage(ex.ToString());
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
                        await telegram.SendSimpleMessage("Invalid url provided");
                        await telegram.SendSimpleMessage(ex.ToString());
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
                        await telegram.SendSimpleMessage("Invalid url provided");
                        await telegram.SendSimpleMessage(ex.ToString());
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

                        command = new GetStreamsByNameCommand(twitch,telegram, name);

                    }
                    catch (IndexOutOfRangeException e)
                    {
                        await message.Channel.SendMessageAsync(
                            "Invalid use of command! Try using !streamsbyname (GAME NAME HERE)");
                        await telegram.SendSimpleMessage("No game name provided");
                        await telegram.SendSimpleMessage(e.ToString());
                    }
                    break;
                //find playlist on spotify 
                case "playlist":
                    command = new FindPlaylistsCommand(spotify, commands[1]);
                    break;
                case "artist":
                    command = new FindArtistOnSpotifyCommand(spotify,commands[1]);
                    break;
                case "albums":
                    await spotify.SearchArtistsAlbums("scarlxrd");
                    break;
                //help command to output any command put to use 
                case "help":
                    command = new HelpCommand();
                    break;
                case "setadminchannel":
                    command = new SetAdminChannelCommand(DiscordApiManager);
                    break;
            }
            if (command != null)
            {
                await command.MessageReply(message);
            }

        }
    }
}
