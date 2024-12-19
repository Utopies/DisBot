using DSharpPlus;

sealed class StartBot
{
    private static DiscordClient  Client { get; set; }
    
    public static async Task Main(string[] args)
    {
        Client = new DiscordClient(SetConfig());
        await Client.ConnectAsync();
        await Task.Delay(-1);
    }

    private static DiscordConfiguration SetConfig()
    {
        var disConfig = new DiscordConfiguration()
        {
            Intents = DiscordIntents.All,
            Token = ReadToken(),
            TokenType = TokenType.Bot,
            AutoReconnect = true,
        };
        
        return disConfig;
    }
    
    private static string ReadToken()
    {
        string token = File.ReadAllText("Token.txt");
        return token;
    }
}