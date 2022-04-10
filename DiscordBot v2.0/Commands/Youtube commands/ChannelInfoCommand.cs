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
        static UIDataUserInputYouTube uidataYT;
        private string apiKey = uidataYT.YouTubeApiKey;
        /// <summary>
        /// Creates a constructor
        /// </summary>
        /// <param name="tubeApiManager">YouTube api manager</param>
        /// <param name="channelId">Channel id that will automatically parse from channel link</param>
        public ChannelInfoCommand(YouTubeApiManager tubeApiManager, string channelId,string apiKey)
        {
            YouTubeApiManager = tubeApiManager;
            channelID = channelId;
            this.apiKey = apiKey; 

        }
        /// <summary>
        /// Inherited from Command, sends message to a channel where the command was input, outputs youtube channel information
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {
            UIDataUserInputYouTube uIDataUserInputYouTube = new UIDataUserInputYouTube();
            var details = await YouTubeApiManager.FindChannelInfo(channelID, apiKey);
            await message.Channel.SendMessageAsync($"Subscribers: {details.Subscribers} \n " +
                $"Vide count: {details.VideoCount} videos on record \n " +
                $"Total views: {details.Views} \n " +
                $"Description: {details.Details}");
        }
        
    }
}
