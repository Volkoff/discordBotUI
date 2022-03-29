using System;
using System.Web;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Api;
using TwitchLib.Api.Helix.Models.Users;
using Discord.WebSocket;
using TwitchLib.Api.V5.Models.Subscriptions;
using System.Net.Http;
using Discord;
using System.Threading.Tasks;
using TwitchLib.Api.Helix.Models.Streams.GetStreams;

namespace DiscordBot_v2._0
{
    internal class TwitchApiManager
    {
        private static TwitchApiManager _instance;
        /// <summary>
        /// setting up a TwitchApiManager instance which will be used in order to connect to the api
        /// </summary>
        public static TwitchApiManager Instance 
        { 
            get 
            { 
                return _instance ?? (_instance = new TwitchApiManager()); 
            } 
        }
        private static TwitchAPI api;
        /// <summary>
        /// setting up the keys
        /// </summary>
        public TwitchApiManager()
        {
            api = new TwitchAPI();
            api.Settings.ClientId = "9m35m8qnrnhe96ht4sdvvmkpfxdldb";
            api.Settings.AccessToken = "irij91q7okoknfh53dw0m88oyfyq1y";
        }
        /// <summary>
        /// Getting user followers 
        /// </summary>
        /// <param name="usernames">username of the channel that is made from the link user sent to the bot</param>
        /// <returns></returns>
        public async Task<TwitchLib.Api.Helix.Models.Users.GetUserFollows.GetUsersFollowsResponse> GetUserFollows(List<string> usernames)
        {
            try
            {
                var users = await api.Helix.Users.GetUsersAsync(logins:usernames);
                if (users.Users.Length == 0)
                {
                    return null;
                }
                string userId = users.Users[0].Id;
                var userFollows = await api.Helix.Users.GetUsersFollowsAsync(toId: userId);
                return userFollows;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Getting games trending on twitch
        /// </summary>
        /// <returns></returns>
        public async Task<TwitchLib.Api.Helix.Models.Games.GetTopGamesResponse>  GetTopGames()
        {
            var games = await api.Helix.Games.GetTopGamesAsync();
            return games;
        }
        /// <summary>
        /// Getting channel information in twitch
        /// </summary>
        /// <param name="usernames">Username of the twitch channel</param>
        /// <returns></returns>
        public async Task<TwitchLib.Api.Helix.Models.Channels.GetChannelInformation.GetChannelInformationResponse> GetChannelInfo(List<string> usernames)
        {
            
            try
            {
                var users = await api.Helix.Users.GetUsersAsync(logins: usernames);
                if (users.Users.Length == 0)
                {
                    return null;
                }
                string userId = users.Users[0].Id;
                var channelInfo = await api.Helix.Channels.GetChannelInformationAsync(userId);
                if (channelInfo == null)
                {
                    return null;
                }
                return channelInfo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Getting 5 popular streams that stream a particular game
        /// </summary>
        /// <param name="game"></param>
        /// <returns></returns>
        public async Task<GetStreamsResponse> GetStreamsByGame(List<string> game)
        {
            try
            {
                List<string> gameIds = new List<string>();
                for (int i = 0; i < 4; i++)
                {
                    var games = await api.Helix.Games.GetGamesAsync(gameNames: game);
                    gameIds.Add(games.Games[0].Id);

                }

                var streams = await api.Helix.Streams.GetStreamsAsync(gameIds: gameIds);
                return streams;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
