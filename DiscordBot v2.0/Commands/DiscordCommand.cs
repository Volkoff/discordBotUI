using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    /// <summary>
    /// abstract class for further use
    /// </summary>
    public abstract class DiscordCommand
    {
        public abstract Task MessageReply(SocketMessage message);
    }
}
