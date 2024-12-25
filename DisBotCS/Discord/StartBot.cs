using System.Transactions;
using DSharpPlus;
using DisBotCS.ReadConfig;
using DSharpPlus.SlashCommands;

namespace DisBotCS.Discord;

class StartBot
{
    private static DiscordClient? Client { get;  set; }

    public static async Task StartBotAsync()
    {
        Client = new DiscordClient(SetConfig());
        
        RegCommands();
        
        await Client.ConnectAsync();
        await Task.Delay(-1);
    }

    private static void RegCommands()
    {
        
        var slashCommands = Client.UseSlashCommands();
        slashCommands.RegisterCommands<DisCommand>();
    }
    
    private static DiscordConfiguration SetConfig()
    {
        var disConfig = new DiscordConfiguration()
        {
            Intents = DiscordIntents.All,
            Token = ConfRead.ReadToken(Bots.Discord),
            TokenType = TokenType.Bot,
            AutoReconnect = true,
        };

        return disConfig;
    }
}