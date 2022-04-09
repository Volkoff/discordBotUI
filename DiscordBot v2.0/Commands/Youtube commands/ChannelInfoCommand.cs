using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class ChannelInfoCommand : Command
    {
        private YouTubeApiManager YouTubeApiManager; //youtubeapi manager instance
        private string channelID;

        /// <summary>
        /// Creates a constructor
        /// </summary>
        /// <param name="tubeApiManager">YouTube api manager</param>
        /// <param name="channelId">Channel id that will automatically parse from channel link</param>
        public ChannelInfoCommand(YouTubeApiManager tubeApiManager, string channelId)
        {
            YouTubeApiManager = tubeApiManager;
            channelID = channelId;
        }
        /// <summary>
        /// Inherited from Command, sends message to a channel where the command was input, outputs youtube channel information
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {
            UIDataUserInputYouTube uIDataUserInputYouTube = new UIDataUserInputYouTube();
            var channelDetails = await YouTubeApiManager.FindChannelInfo(channelID,uIDataUserInputYouTube.YouTubeApiKey);
            await message.Channel.SendMessageAsync($"Subscribers: {channelDetails.Statistics.SubscriberCount} \n " +
                $"Vide count: {channelDetails.Statistics.VideoCount} videos on record \n " +
                $"Total views: {channelDetails.Statistics.ViewCount} \n " +
                $"Description: {channelDetails.BrandingSettings.Channel.Description}");
        }
    }
}
