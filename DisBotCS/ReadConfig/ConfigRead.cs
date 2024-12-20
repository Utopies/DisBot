using Newtonsoft.Json.Linq;

namespace DisBotCS.ReadConfig;

public class ConfigRead
{
    public static string ReadToken(Bots bots)
    {
        var json = File.ReadAllText("Tokens.json");
        JObject config = JObject.Parse(json);

        string token;
        
        switch (bots)
        {
            case Bots.Discord :
                token = config["DisBot"].ToString();
                return token;
        }
        
        return "no token";
    }
}