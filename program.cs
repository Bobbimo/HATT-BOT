using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;



namespace HATT_bot
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

           await _client.LoginAsync(TokenType.Bot, "MzU0NTIxNTI2MTkzODgxMDg4.DJCVGQ.h5LMNYExRyFwnrRenzj67lG_1Ic");

           await _client.StartAsync();

           _handler = new CommandHandler(_client);

           await Task.Delay(-1);
        }
                  
    }
}
