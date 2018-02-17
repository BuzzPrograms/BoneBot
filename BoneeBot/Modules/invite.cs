using System.Threading.Tasks;
using Discord.Commands;

namespace BoneeBot.Modules 
{
    public class invite : ModuleBase<SocketCommandContext>
    {
        [Command ("invite")]
        public async Task inviteb()
        {
        await Context.Channel.SendMessageAsync("```Invite mensen via deze link: https://discord.gg/fEaUgWY! ```");
        }
    }
}
