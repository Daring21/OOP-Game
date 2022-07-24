using System.Text;
using Core.Models.Json;
using Newtonsoft.Json;

namespace Core.Helpers;

public static class FileHelper
{
    public static string ReadTxtFile(string path)
    {
        if (!File.Exists(path))
        {
            return "";
        }

        var text = File.ReadAllText(path, Encoding.UTF8);
        return text;
    }

    public static JsonLevels GetAllLevels(string path)
    {
        var json = ReadTxtFile(path);
        return JsonConvert.DeserializeObject<JsonLevels>(json);
    }
}