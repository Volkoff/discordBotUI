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

    internal class YouTubeChannelDetails 
    {
        public ulong? Subscribers { get; set; }
        public ulong? VideoCount { get; set; }
        public ulong? Views { get; set; }
        public string Details { get; set; }
    }

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
        private string apiKey;
        public YouTubeApiManager(string apiKey)
        {
            this.apiKey = apiKey;
        }
        /// <summary>
        /// Finds popular videos in a region
        /// </summary>
        /// <param name="region">region which is alpha1-2 from the region_codes.csv</param>
        /// <returns></returns>
        public async Task<IList<Video>> FindingTopPopular(string region)
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
        public async Task<YouTubeVideoDetails> FindDetailsOfVideo(string videoID)
        {
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey
                
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
        public async Task<YouTubeChannelDetails> FindChannelInfo(string channelUserName)
        {
            var service = new YouTubeService(new BaseClientService.Initializer() //setting up an API key for youtube 
            {
                ApiKey = apiKey
            });
            var request = service.Channels.List("statistics");
            var requestSnippet = service.Channels.List("brandingSettings");
            requestSnippet.Id = channelUserName;
            request.Id = channelUserName;
            var responseSnippet = await requestSnippet.ExecuteAsync();
            var response = await request.ExecuteAsync();
            var details = response.Items.FirstOrDefault();
            var detailsSnippet = responseSnippet.Items.FirstOrDefault();
            YouTubeChannelDetails channelDetails = new YouTubeChannelDetails()
            {
                Subscribers = details.Statistics.SubscriberCount,
                VideoCount = details.Statistics.VideoCount,
                Views = details.Statistics.ViewCount,
                Details = detailsSnippet.BrandingSettings.Channel.Description
            };

            return channelDetails;
            
        }

    }
}

//"AIzaSyBgNlxqFo2N3MizsKNJmD1VQhICHPcF0CM"