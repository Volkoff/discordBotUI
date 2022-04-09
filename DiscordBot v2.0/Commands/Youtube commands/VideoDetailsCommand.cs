using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class VideoDetailsCommand : Command
    {
        private YouTubeApiManager youtubeApiManager;
        private string videoId;
        static UIDataUserInputYouTube uidataYT;
        private string apiKey = uidataYT.YouTubeApiKey;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="youTubeApi">Youtube api instance</param>
        /// <param name="videoId">Video id made from the link</param>
        public VideoDetailsCommand(YouTubeApiManager youTubeApi,string videoId, string apiKey)
        {
            youtubeApiManager = youTubeApi;
            this.videoId = videoId;
            this.apiKey = apiKey;
        }
        /// <summary>
        /// Returns video content details 
        /// </summary>
        /// <param name="message">Socket message instance</param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {
            var videoDetails = await youtubeApiManager.FindDetailsOfVideo(videoId,apiKey);
            await message.Channel.SendMessageAsync($"Title: {videoDetails.Title} \n " +
                $"Description: {videoDetails.Description} \n " +
                $"Channel: {videoDetails.ChannelTitle} \n " +
                $"Made at: {videoDetails.PublicationDate} \n" +
                $"Likes: {videoDetails.Likes} \n");
        }
    }
}
