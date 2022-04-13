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
            var config = SpotifyClientConfig
                .CreateDefault()
                ;
            var request =
                new ClientCredentialsRequest("0aaa8181b2a84f6e9ac9fac37477db88", "b4737b685f594bf7af5565f37a076eaf");
            var response = await new OAuthClient(config).RequestToken(request);
            spotifyInstance = new SpotifyClient(config.WithToken(response.AccessToken));
            return null;
        }
        public async Task<string> FindSong(string query)
        {
            await AccessToken();
            SearchResponse searchResponse = await spotifyInstance.Search.Item(new SearchRequest(SearchRequest.Types.Track,query));
            string songUrl = searchResponse.Tracks.Items[0].ExternalUrls["spotify"];
            return songUrl;
        }
        
        public async Task<string[]> SearchArtist(string query)
        {
            await AccessToken();
            SearchResponse searchResponse = await spotifyInstance.Search.Item(new SearchRequest(SearchRequest.Types.Artist, query));
            string imageArtist = searchResponse.Artists.Items[0].Images[0].Url;
            string name = "Name: " + searchResponse.Artists.Items[0].Name;
            string followers = "Follower count: " + searchResponse.Artists.Items[0].Followers.Total.ToString();
            var artistGenre = searchResponse.Artists.Items[0].Genres;
            List<string> artistGenres = new List<string>();
            foreach(string genre in artistGenre)
            {
                artistGenres.Add(genre);
            }
            string allArtistGenres = "Genres: " + String.Join(", ", artistGenres.ToArray());
            string popularity = "Popularity: " + searchResponse.Artists.Items[0].Popularity.ToString() + "%";
            string[] artistInfo = {
                imageArtist,
                name,
                followers,
                allArtistGenres,
                popularity
                };
            return artistInfo;
        }

        public async Task<string[]> SearchArtistsAlbums(string query)
        {
            await AccessToken();
            SearchResponse searchArtistResponse = await spotifyInstance.Search.Item(new SearchRequest(SearchRequest.Types.Artist, query));
            SearchResponse searchResponse = await spotifyInstance.Search.Item(new SearchRequest(SearchRequest.Types.Album, searchArtistResponse.Artists.Items[0].Id));
            var totalAlbums = searchResponse.Albums.Total;
            for (int i = 0; i < 5; i++)
            {
                string nameOfAlbum = searchResponse.Albums.Items[i].Name;
                string releaseDate = searchResponse.Albums.Items[i].ReleaseDate;
                string albumType = searchResponse.Albums.Items[i].AlbumType;
                string albumGroup = searchResponse.Albums.Items[i].AlbumGroup;
                string totalTracks = searchResponse.Albums.Items[i].TotalTracks.ToString();
                var restrictions = searchResponse.Albums.Items[i].Restrictions;
                List<string> restrictionsList = new List<string>();
                restrictionsList = restrictions.Values.ToList();

            }
            return null;
        }

        public async Task<List<string[]>> FindPlaylist(string query)
        {
            await AccessToken();
            SearchResponse searchResponse = await spotifyInstance.Search.Item(new SearchRequest(SearchRequest.Types.Playlist, query));
            List<string[]> allResults = new List<string[]>();
            for (int i = 0; i < 5; i++)
            {
                string playlistUrl;
                string imageUrlString;
                var URL = searchResponse.Playlists.Items[i].ExternalUrls;
                List<string> urlList = new List<string>();
                urlList = URL.Values.ToList();
                playlistUrl = urlList[0];
                
                string spotifyName = "Name: " + searchResponse.Playlists.Items[i].Name;
                string totalTracks = "Total: " + searchResponse.Playlists.Items[i].Tracks.Total.ToString();
                string description = "Description: " + searchResponse.Playlists.Items[i].Description;
                string isCollaborative = "Is collaborative: " + searchResponse.Playlists.Items[i].Collaborative.ToString();
                string owner = "Owner: " + searchResponse.Playlists.Items[i].Owner.DisplayName;
                string image = searchResponse.Playlists.Items[i].Images[0].Url;
                if (description == "Description: ")
                {
                    description = "<No description provided>";
                }
                string[] onePlaylist = {
                image,
                spotifyName,
                totalTracks,
                description,
                isCollaborative,
                owner,
                playlistUrl
                };

                allResults.Add(onePlaylist);
            }

            return allResults;
        }

        public async Task<string> CreatePlaylist(string playlistName)
        {
            await AccessToken();
            //await Authentication(LoginRequest.ResponseType.Code);
            //PrivateUser currentUser = await spotifyInstance.UserProfile.;
            string userID = "a0q8vwpqylhtu9v8mcnjugla3";
            var playlist = await spotifyInstance.Playlists.Create(userID, new PlaylistCreateRequest("Poshelnahui maxim") 
            { 
                Collaborative = false,
                Description = "na",
                Public = true
            });
            string uri = playlist.Uri;
            //Console.WriteLine(spotifyInstance.UserProfile.Current().Result.Email);
            //playlist.Public = false;
            //playlist.Collaborative = true;
            //Console.WriteLine(playlist.Uri);
            return null;
        }

        
    }
}
