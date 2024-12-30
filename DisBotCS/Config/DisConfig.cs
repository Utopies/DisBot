using DSharpPlus;
using DSharpPlus.CommandsNext;

namespace DisBotCS.Config;

public class DisConfig
{
    protected static DiscordConfiguration GetConfigClient()
    {
        var disConfig = new DiscordConfiguration()
        {
            Intents = DiscordIntents.All,
            Token = ConfReadFiles.ReadToken(),
            TokenType = TokenType.Bot,
            AutoReconnect = true,
        };

        return disConfig;
    }

    protected static CommandsNextConfiguration GetConfigCommand() 
        => new CommandsNextConfiguration() { StringPrefixes = new[] { "*" } };
}