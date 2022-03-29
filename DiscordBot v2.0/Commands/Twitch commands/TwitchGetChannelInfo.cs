using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class TwitchGetChannelInfo : Command
    {
        private TwitchApiManager twitchApiManager;
        private List<string> usernames;
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="twitchApiManager"> Twitchmanager instance</param>
        /// <param name="usernames">Username made from link</param>
        public TwitchGetChannelInfo(TwitchApiManager twitchApiManager, List<string> usernames)
        {
            this.twitchApiManager = twitchApiManager;
            this.usernames = usernames;
        }
        /// <summary>
        /// Replying with channel information, uses two methods
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {var emojiSad = new Emoji("😔");
            try
            {
                TwitchLib.Api.Helix.Models.Channels.GetChannelInformation.GetChannelInformationResponse channelInfo = await twitchApiManager.GetChannelInfo(usernames);
                TwitchLib.Api.Helix.Models.Users.GetUserFollows.GetUsersFollowsResponse followers = await twitchApiManager.GetUserFollows(usernames);
                if (channelInfo == null)
                {
                    await message.Channel.SendMessageAsync("Sorry we could not find the channel");
                    return;
                }
                await message.Channel.SendMessageAsync("Streamer: " + channelInfo.Data[0].BroadcasterName);
                await message.Channel.SendMessageAsync("Subscriber count: " + followers.TotalFollows);
                await message.Channel.SendMessageAsync("Streaming: " + channelInfo.Data[0].GameName);
                await message.Channel.SendMessageAsync(channelInfo.Data[0].Title);
                await message.Channel.SendMessageAsync($"https://static-cdn.jtvnw.net/ttv-boxart/{channelInfo.Data[0].GameId}-188x250.jpg");
            }
            catch (Exception ex)
            {
                await message.Channel.SendMessageAsync("Sorry about it, something went wrong");
                await message.AddReactionAsync(emojiSad);
            }
        }
    }
}
