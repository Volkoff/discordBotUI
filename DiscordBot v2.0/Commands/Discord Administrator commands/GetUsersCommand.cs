using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot_v2._0
{
    internal class GetUsersCommand : TelegramCommand
    {
        DiscordApiManager discordApiManager;
        public GetUsersCommand(DiscordApiManager discordApiManager)
        {
            this.discordApiManager = discordApiManager;
        }

        public override Task MessageReply(Telegram.Bot.Types.Message message)
        {
            throw new NotImplementedException();
        }
    }
}
