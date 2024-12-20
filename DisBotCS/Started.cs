namespace DisBotCS
{
    sealed class Started
    {
        public static async Task Main(string[] args)
        {
            var dis = Discord.StartBot.StartBotAsync();
            //var tg = Telegram.StartBot.StartBotAsync();

            await Task.WhenAll(dis);
        }
    }
}