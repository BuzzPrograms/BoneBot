using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace BoneeBot
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "NDE0NDI5NzI3NjA5MDYxMzg3.DWnRLg.F9XxOGgx1J-4UZlvKzL7xuDi13I");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await _client.SetGameAsync("!help | play.bonecraft.tk");

            await Task.Delay(-1);
        }

    }
}
