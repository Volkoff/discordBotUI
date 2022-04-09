using Discord.WebSocket;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class YtPopsCommand : Command
    {
        UIDataUserInputYouTube inputYouTube;
        private YouTubeApiManager youtubeApiManager;
        private string region;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="youtubeApi">Youtubeapi instance</param>
        /// <param name="region">Region input by user</param>
        public YtPopsCommand(YouTubeApiManager youtubeApi, string region)
        {
            youtubeApiManager = youtubeApi;
            this.region = region;
        }
        /// <summary>
        /// Sends the youtube popular videos
        /// Handles an error when region code is invalid
        /// </summary>
        /// <param name="message">SocketMessage instance</param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {
            IList<Video> videos = await youtubeApiManager.FindingTopPopular(region,inputYouTube.YouTubeApiKey);
            if(videos == null)
            {
                await message.Channel.SendMessageAsync("Region not found");
                return;
            }

            foreach (var video in videos)
            {
                await message.Channel.SendMessageAsync($"================ \n {video.Snippet.Title} \n [http://www.youtube.com/watch?v={video.Id}]");
            }
        }
    }
}
