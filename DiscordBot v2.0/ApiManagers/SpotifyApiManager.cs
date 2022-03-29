using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using SpotifyAPI.Web;

namespace DiscordBot_v2._0
{
    //NOT IMPLEMENTED DO NOT USE
    internal class SpotifyApiManager
    {
        private SpotifyClient spotifyInstance;
        private async Task Authentication(string code)
        {
            Uri redirect = new Uri("http://localhost:5000");
            var response = await new OAuthClient().RequestToken(
                new AuthorizationCodeTokenRequest("0aaa8181b2a84f6e9ac9fac37477db88", "b4737b685f594bf7af5565f37a076eaf", code,redirectUri:redirect)
            );
           
        }

        private async Task<string> AccessToken()
        {
            var config = SpotifyClientConfig.CreateDefault();
            var request =
                new ClientCredentialsRequest("0aaa8181b2a84f6e9ac9fac37477db88", "b4737b685f594bf7af5565f37a076eaf");
            var response = await new OAuthClient(config).RequestToken(request);
            return response.ToString();
        }
        public async Task<string> FindSong(string query)
        {
            await AccessToken();
            SearchResponse searchResponse = await spotifyInstance.Search.Item(new SearchRequest(SearchRequest.Types.Track,query));
            string songUrl = searchResponse.Tracks.Items[0].ExternalUrls["spotify"];
            return songUrl;
        }
        
    
        public async Task<string> Something(SocketMessage message)
        {
            await AccessToken();
            //await Authentication(LoginRequest.ResponseType.Code);
            var playlist = await spotifyInstance.Playlists.Create(spotifyInstance.UserProfile.Current().Id.ToString(), new PlaylistCreateRequest("Poshelnahui maxim"));
            
            //Console.WriteLine(spotifyInstance.UserProfile.Current().Result.Email);
            //playlist.Public = false;
            //playlist.Collaborative = true;
            //Console.WriteLine(playlist.Uri);
            return null;
        }
    }
}
