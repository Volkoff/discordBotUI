using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Message = Telegram.Bot.Types.Message;

namespace DiscordBot_v2._0
{
    public abstract class TelegramCommand
    {
        public abstract Task MessageReply(Message message);
    }
}
