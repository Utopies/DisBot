using DSharpPlus.SlashCommands;
using DisBotCS.Config;

namespace DisBotCS.Command;

public class DisCommand : ApplicationCommandModule
{
    [SlashCommand("help", "Помощь с командами")]
    public async Task HelpCom(InteractionContext ctx)
    {
        await ctx.Channel.SendMessageAsync(ConfReadFiles.ReadTxtFile("help.txt", "discord"));
    }
    
    [SlashCommand("bot_info" , "Информация о боте")]
    public async Task BotInfo(InteractionContext ctx)
    {
        await ctx.Channel.SendMessageAsync(ConfReadFiles.ReadTxtFile("BotInfo.txt", "discord"));
    }

    [SlashCommand("nometa", "Избегайте мета вопросов")]
    public async Task Nometa(InteractionContext ctx)
    {
        await ctx.Channel.SendMessageAsync("[избегайте мета вопросов](https://nometa.xyz)");
    }
}