using Newtonsoft.Json.Linq;

namespace DisBotCS.ReadConfig;

public class ConfRead
{
    public static string ReadToken(Bots bots)
    {
        var json = File.ReadAllText("Tokens.json");
        JObject config = JObject.Parse(json);

        string? token;
        
        switch (bots)
        {
            case Bots.Discord:
                token = config["DisBot"].ToString();
                return token;
            case Bots.Telegram: //окей, спасиб
                return token = config["Telegram"].ToString();
        }
        
        return null;
    }

    public static string ReadTxtFile(string filename)
    {
        return File.ReadAllText(filename);
    }
    
    public static string ReadTxtFile(string filename, string path)
    {
        filename = Path.Combine(path, filename);
        return File.ReadAllText(filename);
    }
}