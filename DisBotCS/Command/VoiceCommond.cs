using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.VoiceNext;

namespace DisBotCS.Command;

public class VoiceCommond : BaseCommandModule
{
    [Command("join")]
    public async Task JoinCommand(CommandContext ctx, DiscordChannel channel = null) 
        => await ctx.Member.VoiceState.Channel.ConnectAsync();
    
    [Command("leave")]
    public async Task LeaveCommand(CommandContext ctx)
        => ctx.Client.GetVoiceNext().GetConnection(ctx.Guild).Disconnect();

    // [Command("play")]
    // public async Task PlayCommand(CommandContext ctx, string path)
    // {
    //     var transmit = ctx.Client.GetVoiceNext().GetConnection(ctx.Guild).GetTransmitSink();
    //
    //     var pcm = ConvertAudioToPcm(path);
    //     await pcm.CopyToAsync(transmit);
    //     await pcm.DisposeAsync();
    // }

    // private Stream ConvertAudioToPcm(string filePath)
    // {
    //     var ffmpeg = Process.Start(new ProcessStartInfo
    //     {
    //         FileName = "ffmpeg",
    //         Arguments = $@"-i ""{filePath}"" -ac 2 -f s16le -ar 48000 pipe:1",
    //         RedirectStandardOutput = true,
    //         UseShellExecute = false
    //     });
    //
    //     return ffmpeg.StandardOutput.BaseStream;
    // }
}