using System.Threading.Tasks;
using Discord.Commands;

namespace BoneeBot.Modules
{
    public class help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task helpb()
        {
            string msg = "```Help @!help -- Lijst met alle commands. @!invite -- Link van de Discord-server. @!ip -- Het ip adres van de Minecraft-server!```";
            msg = msg.Replace("@", System.Environment.NewLine);

            await Context.Channel.SendMessageAsync(msg);
        }
    }
}