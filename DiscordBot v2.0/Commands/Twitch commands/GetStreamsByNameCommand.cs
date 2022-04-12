using System.Collections.Generic;
using System.Threading.Tasks;
using Discord.WebSocket;
using TwitchLib.Api.Helix.Models.Channels.GetChannelInformation;
using TwitchLib.Api.Helix.Models.Streams.GetStreams;

namespace DiscordBot_v2._0
{
    internal class GetStreamsByNameCommand : DiscordCommand
    {
        private TwitchApiManager twitchApiManager;
        private TelegramApiManager telegramApiManager;
        private List<string> games;
        public GetStreamsByNameCommand(TwitchApiManager twitchApiManager,TelegramApiManager telegramApiManager,List<string> games)
        {
            this.twitchApiManager = twitchApiManager;
            this.telegramApiManager = telegramApiManager;
            this.games = games;
        }
        public override async Task MessageReply(SocketMessage message)
        {
            GetStreamsResponse gamesResp = await twitchApiManager.GetStreamsByGame(games);
            if (gamesResp == null)
            {
                await telegramApiManager.SendSimpleMessage("Null message received, game name unknown");
                await message.Channel.SendMessageAsync("Something went wrong");
            }
            for (int i = 0; i < 5; i++)
            {
                await message.Channel.SendMessageAsync("------------------------------------");
                await message.Channel.SendMessageAsync("Streamer name: " +gamesResp.Streams[i].UserName);
                await message.Channel.SendMessageAsync($"People watching: " + gamesResp.Streams[i].ViewerCount);
                await message.Channel.SendMessageAsync($"Started at: " + gamesResp.Streams[i].StartedAt);
                await message.Channel.SendMessageAsync($"Language: " + gamesResp.Streams[i].Language);
                await message.Channel.SendMessageAsync($"https://www.twitch.tv/{gamesResp.Streams[i].UserName}");
                
            }
        }
    }
}