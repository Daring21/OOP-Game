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
            Door door => door.Letter.ToString(),
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

    public static void DrawMessageFromFile(string path, ConsoleColor color)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(FileHelper.ReadTxtFile(Path.Combine(Directory.GetCurrentDirectory(), path)));
        Console.ForegroundColor = previousColor;
    }
    
    public static void DrawGreetingMessage()
    {
        DrawMessageFromFile(@"Assets/Messages/greeting.txt", ConsoleColor.Blue);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPress \"ENTER\" to start!");
    }
}
