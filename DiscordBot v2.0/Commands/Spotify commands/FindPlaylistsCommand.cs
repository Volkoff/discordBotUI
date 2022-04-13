using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class FindPlaylistsCommand : DiscordCommand
    {
        private SpotifyApiManager spotifyApiManager;
        private string playlistName;

        public FindPlaylistsCommand(SpotifyApiManager spotifyApiManager,string playlistName)
        {
            this.spotifyApiManager = spotifyApiManager;
            this.playlistName = playlistName;
        }
        public override async Task MessageReply(SocketMessage message)
        {
            await message.Channel.SendMessageAsync("Looking for playlist");
            List<string[]> playlists = await spotifyApiManager.FindPlaylist(playlistName);
            foreach(string[] playlist in playlists)
            {
                foreach(string item in playlist)
                {
                    await message.Channel.SendMessageAsync(item);
                }
            await message.Channel.SendMessageAsync("=============");
            }
        }
    }
}
