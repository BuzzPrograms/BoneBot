using System.Threading.Tasks;
using Discord.Commands;

namespace BoneeBot.Modules
{
    public class ip : ModuleBase<SocketCommandContext>
    {
        [Command("ip")]
        public async Task ipb()
        {
            string msg = "```Het ip van de server is play.bonecraft.tk.```";
            msg = msg.Replace("@", System.Environment.NewLine);

            await Context.Channel.SendMessageAsync(msg);
        }
    }
}