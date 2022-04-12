using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class GetTopGamesCommand : DiscordCommand
    {
        private TwitchApiManager twitchApiManager;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="twitchApiManager">TwitchApiManagerInstance</param>
        public GetTopGamesCommand(TwitchApiManager twitchApiManager)
        {
            this.twitchApiManager = twitchApiManager;
        }
        /// <summary>
        /// Sends Top games streamed on twitch
        /// </summary>
        /// <param name="message">Socket message instance</param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {
            TwitchLib.Api.Helix.Models.Games.GetTopGamesResponse topGames = await twitchApiManager.GetTopGames(); //
            await message.Channel.SendMessageAsync("Most popular games on twitch now!");
            for (int i = 0; i < 5; i++)
            {
                await message.Channel.SendMessageAsync(topGames.Data[i].Name);
                await message.Channel.SendMessageAsync($"https://static-cdn.jtvnw.net/ttv-boxart/{topGames.Data[i].Id}-188x250.jpg");
            }

        }
    }
}
