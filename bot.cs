using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HATT_bot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        private object author;

        public string Command { get; private set; }

        [Command("Test")]
        public async Task testtext()
        {
            await Context.Channel.SendMessageAsync("Det funkar!");
        }

        [Command("donde")]
        public async Task Leche()
        {
            await Context.Channel.SendMessageAsync("¿Donde esta la leche?");
        }

        [Command("skrt")]
        
        public async Task skirt()
        {
            await Context.Channel.SendMessageAsync("Skrt!");
        }

        [Command("neger")]

        public async Task Neger()
        {
            await Context.Channel.SendMessageAsync("Använd inte sådana fula ord! USH!");
        }
    }
}
