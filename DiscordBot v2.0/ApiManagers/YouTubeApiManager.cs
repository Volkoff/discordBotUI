using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Discord;

namespace DiscordBot_v2._0
{
    /// <summary>
    /// class that helps YouTube video details in outputting
    /// </summary>
    internal class YouTubeVideoDetails
    {
        public string VideoId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ChannelTitle { get; set; }
        public DateTime? PublicationDate { get; set; }
        public ulong? Likes { get; set; }
    }
    internal class YouTubeApiManager
    {
        /// <summary>
        /// Finds popular videos in a region
        /// </summary>
        /// <param name="region">region which is alpha1-2 from the region_codes.csv</param>
        /// <returns></returns>
        public async Task<IList<Video>> FindingTopPopular(string region,string apiKey)
        {

            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey
            });

            var request = service.Videos.List("snippet");
            request.Chart = VideosResource.ListRequest.ChartEnum.MostPopular;

            try
            {
                request.RegionCode = region;


                var result = await request.ExecuteAsync();

                if (result.Items.Count <= 0)
                {
                    Console.WriteLine("error getting the list");
                }
                return result.Items;
                
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        /// <summary>
        /// Finds all details about the video
        /// </summary>
        /// <param name="videoID">Video id, made from video link</param>
        /// <returns></returns>
        public async Task<YouTubeVideoDetails> FindDetailsOfVideo(string videoID, string apiKey)
        {
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyBgNlxqFo2N3MizsKNJmD1VQhICHPcF0CM"
                
            }); ;

            var request = service.Videos.List("snippet");
            var requestStats = service.Videos.List("statistics");
            request.Id = videoID;
            requestStats.Id = videoID;
            var statResponse = await requestStats.ExecuteAsync();
            var searchResponse = await request.ExecuteAsync();
            var youTubeVideo = searchResponse.Items.FirstOrDefault();
            var youTubeVideoStats = statResponse.Items.FirstOrDefault();

            YouTubeVideoDetails videoDetails = new YouTubeVideoDetails()
            {
                VideoId = youTubeVideo.Id,
                Description = youTubeVideo.Snippet.Description,
                Title = youTubeVideo.Snippet.Title,
                ChannelTitle = youTubeVideo.Snippet.ChannelTitle,
                PublicationDate = youTubeVideo.Snippet.PublishedAt,
                Likes = youTubeVideoStats.Statistics.LikeCount,
            };
            return videoDetails;
        }
        
        /// <summary>
        /// Finding channel info based off the channel link sent by user
        /// </summary>
        /// <param name="channelUserName">channel username</param>
        /// <returns></returns>
        public async Task<Channel> FindChannelInfo(string channelUserName, string apiKey)
        {
            var service = new YouTubeService(new BaseClientService.Initializer() //setting up an API key for youtube 
            {
                ApiKey = "AIzaSyBgNlxqFo2N3MizsKNJmD1VQhICHPcF0CM"
            });
            List<String> parts = new List<String>();
            parts.Add("statistics");
            parts.Add("brandingSettings");
            var request = service.Channels.List(parts); //making a request
            var searchRequest = service.Search.List(channelUserName);
            var searchListResponse = await searchRequest.ExecuteAsync(); //getting a response 
            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#channel":
                        channelUserName = searchResult.Id.ChannelId;
                        break;
                }
            }

            request.Id = channelUserName;
            var response = await request.ExecuteAsync();
            var channelDetails = response.Items.FirstOrDefault();
            return channelDetails;
        }

    }
}