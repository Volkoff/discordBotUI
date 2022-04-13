using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class FindArtistOnSpotifyCommand : DiscordCommand
    {
        private SpotifyApiManager spotifyApiManager;
        private string artistName;
        public FindArtistOnSpotifyCommand(SpotifyApiManager spotifyApiManager, string artistName)
        {
            this.spotifyApiManager = spotifyApiManager;
            this.artistName = artistName;
        }
        public override async Task MessageReply(SocketMessage message)
        {
            await message.Channel.SendMessageAsync("Looking for an artist");
            string[] artistInfo = await spotifyApiManager.SearchArtist(artistName);
            foreach (string item in artistInfo)
            {
                await message.Channel.SendMessageAsync(item);
            }
            await message.Channel.SendMessageAsync("=============");
        }
    }
}
