using Newtonsoft.Json.Linq;

namespace DisBotCS.Config;

public class ConfReadFiles
{
    public static string ReadToken()
    {
        var json = File.ReadAllText("Tokens.json");
        JObject config = JObject.Parse(json);
        
        return config["DisBot"].ToString();
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