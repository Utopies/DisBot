using DSharpPlus;
using DisBotCS.ReadConfig;

namespace DisBotCS.Discord;

class StartBot
{
    private static DiscordClient Client { get;  set; }

    public static async Task StartBotAsync()
    {
        Client = new DiscordClient(SetConfig());
        
        Client.ConnectAsync();
        await Task.Delay(-1);
    }
    
    private static DiscordConfiguration SetConfig()
    {
        var disConfig = new DiscordConfiguration()
        {
            Intents = DiscordIntents.All,
            Token = ConfigRead.ReadToken(Bots.Discord),
            TokenType = TokenType.Bot,
            AutoReconnect = true,
        };

        return disConfig;
    }
}