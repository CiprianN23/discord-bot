using System;
using System.Threading.Tasks;
using Discord.WebSocket;
using DiscordBot.Discord;
using DiscordBot.Discord.Entities;
using DiscordBot.Storage;

namespace DiscordBot
{
    internal class Program
    {
        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("Hello, Discord!");

            var storage = Unity.Resolve<IDataStorage>();

            var connection = Unity.Resolve<Connection>();

            await connection.ConnectAsync(new BotConfig
            {
                Token = storage.RestoreObject<string>("Config/BotToken")
            });

            Console.ReadKey();
        }
    }
}
