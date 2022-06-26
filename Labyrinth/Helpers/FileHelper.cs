using System.Text;
using Labyrinth.Models;
using Newtonsoft.Json;

namespace Labyrinth.Helpers;

public static class FileHelper
{
    public static string ReadTxtFile(string path)
    {
        if (File.Exists(path))
        {
            var text = File.ReadAllText(path, Encoding.UTF8);
            return text;
        }

        return "";
    }

    public static JsonLevels GetAllLevels(string path)
    {
        var json = ReadTxtFile(path);
        return JsonConvert.DeserializeObject<JsonLevels>(json);
    }
}
