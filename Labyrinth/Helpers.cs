using System.Media;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Labyrinth;

public static class Helpers
{
    private static string ReadTxtFile(string path)
    {
        if (File.Exists(path))
        {
            var text = File.ReadAllText(path, Encoding.UTF8);
            return text;
        }

        return "";
    }

    public static void DrawSymbolsOnTheMap()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Wall — '█', Player — 'o', Door — '▒', Key — '╒'");
        Console.WriteLine("Use arrows to move!\n");
        Console.ForegroundColor = previousColor;
    }

    public static void DrawGreetingMessage()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(ReadTxtFile(Path.Combine(Directory.GetCurrentDirectory(),
            @"../../../Assets/Messages/greeting.txt")));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPress \"ENTER\" to start!");
        Console.ForegroundColor = previousColor;
    }

    public static void DrawWonMessage()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            ReadTxtFile(Path.Combine(Directory.GetCurrentDirectory(), @"../../../Assets/Messages/won.txt")));
        Console.ForegroundColor = previousColor;
    }

    public static void PlayAchieveSound()
    {
        var soundLocation = Path.Combine(Directory.GetCurrentDirectory(), @"../../../Assets/Sounds/achieve.wav");
        using var player = new SoundPlayer(soundLocation);
        player.Play();
    }

    public static void PlayBackgroundSound()
    {
        var soundLocation = Path.Combine(Directory.GetCurrentDirectory(), @"../../../Assets/Sounds/background.wav");
        using var player = new SoundPlayer(soundLocation);
        player.PlayLooping();
    }
}
