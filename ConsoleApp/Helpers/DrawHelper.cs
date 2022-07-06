using Core.Helpers;
using Core.Models;

namespace ConsoleApp.Helpers;

public static class DrawHelper
{
    public static void DrawElement(object? sender, EventArgs e)
    {
        if (sender is not GameElement element)
        {
            return;
        }

        var symbol = element switch
        {
            Door => ((Door) element).Letter.ToString(),
            Empty => " ",
            Exit => "▒",
            Key key => key.Letter.ToString(),
            Player => "¤",
            Wall => "█",
            _ => " "
        };

        var color = element switch
        {
            Door => ConsoleColor.Red,
            Empty => ConsoleColor.White,
            Exit => ConsoleColor.Magenta,
            Key => ConsoleColor.Green,
            Player => ConsoleColor.Blue,
            Wall => ConsoleColor.White,
            _ => ConsoleColor.White
        };
        
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.SetCursorPosition(element.X, element.Y);
        
        if (element is Door)
        {
            Console.Write(symbol.ToUpper());
        }
        else
        {
            Console.Write(symbol);
        }
        
        Console.ForegroundColor = previousColor;
        if (element is Player)
        {
            Console.SetCursorPosition(0, 10);
        }
    }
    
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
