namespace Core.Helpers;

public static class DrawHelper
{
    public static void DrawSymbolsOnTheMap()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nWall — '█', Player — '¤', Door — 'A', Key — 'a', Exit — '▒'");
        Console.WriteLine("Use arrows to move!\n");
        Console.ForegroundColor = previousColor;
    }

    public static void DrawGreetingMessage()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(FileHelper.ReadTxtFile(Path.Combine(Directory.GetCurrentDirectory(),
            @"Assets/Messages/greeting.txt")));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPress \"ENTER\" to start!");
        Console.ForegroundColor = previousColor;
    }

    public static void DrawWonMessage()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            FileHelper.ReadTxtFile(Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Messages/won.txt")));
        Console.ForegroundColor = previousColor;
    }
}
