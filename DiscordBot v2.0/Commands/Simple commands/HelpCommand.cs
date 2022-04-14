using System.Collections.Generic;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace DiscordBot_v2._0
{
    internal class HelpCommand : DiscordCommand
    {
        /// <summary>
        /// Sends a helping message to a channel where was the command called
        /// </summary>
        /// <param name="message">SocketMessage instance</param>
        /// <returns></returns>
        public override async Task MessageReply(SocketMessage message)
        {
            var commands = new Dictionary<string, string>()
            {
                {"!hello", "returns a greeting to a user"},
                {"!ytpops (region)", "Returns top videos in region on YouTube"},
                {"!videodetails (Video link)", "Returns video details on YouTube"},
                {"!channelinfo (channel link)", "Returns channel info from YouTube"},
                {"!twitchchan (channel link)", "Returns channel info from Twitch"},
                {"!twitchgames", "Returns top games streamed on Twitch"},
                {"!streamsbyname", "Returns top 5 streams by a game name"},
                {"!playlist (playlist name)","returns public playlists on spotify" },
                {"!artist (artist name)","returns artist information on spotify" }


            };
            foreach (KeyValuePair<string, string> command in commands) //Loop for getting all the commands
            {
                await message.Channel.SendMessageAsync($"{command.Key} - {command.Value}");
            }
        }
    }
}