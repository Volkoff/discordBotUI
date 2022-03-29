using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Discord;
using Discord.WebSocket;
using Telegram.Bot.Types;

namespace DiscordBot_v2._0
{
    public class CSVReader
    {
        /// <summary>
        /// Sending the region_codes.csv file
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendFile(SocketMessage message)
        {
            await message.Channel.SendFileAsync("region_codes");
        }
        
    }
}
        
    
