﻿using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class FindSongOnSpotifyCommand : DiscordCommand
    {
        private SpotifyApiManager spotifyApiManager;
        private string nameOfSong;
        public FindSongOnSpotifyCommand(SpotifyApiManager spotifyApiManager, string name)
        {
            this.spotifyApiManager = spotifyApiManager;
            nameOfSong = name;
        }

        public override async Task MessageReply(SocketMessage message)
        {   
            await message.Channel.SendMessageAsync("Looking for song");
            string songUrl = await spotifyApiManager.FindSong(nameOfSong);
            await message.Channel.SendMessageAsync(songUrl);
        }

    }
}
