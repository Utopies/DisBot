using DisBotCS.Command;
using DisBotCS.Config;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.SlashCommands;
using DSharpPlus.VoiceNext; 

namespace DisBotCS;

class Started : DisConfig
{
    private static DiscordClient? Client { get;  set; }

    public static async Task Main()
    {
        Client = new DiscordClient(GetConfigClient());
        
        var regCom = RegCommands();
        var voice = UseVoiceNext();
        
        await Task.WhenAll(voice, regCom);
        await Client.ConnectAsync();
        await Task.Delay(-1); 
    }
    
    private static async Task RegCommands()
    {
        if (Client != null) {
            var slashCommands = Client.UseSlashCommands();
            var command = Client.UseCommandsNext(GetConfigCommand());
            
            command.RegisterCommands<VoiceCommond>();
            slashCommands.RegisterCommands<DisCommand>();
        }
    }

    private static async Task<VoiceNextExtension> UseVoiceNext() => Client.UseVoiceNext();
}