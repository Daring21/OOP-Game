using Core.Helpers;
using Core.Models;
using Core.Models.GameElements;

namespace ConsoleApp.Helpers;

public static class DrawHelper
{
    public static void DrawElement(object? sender, EventArgs e)
    {
        if (sender is not GameElement element)
        {
            return;
        }

        Dictionary<Type, (string, ConsoleColor)> elementSymbolDictionary = new()
        {
            {typeof(Door), ((element as Door)?.Letter.ToString(), ConsoleColor.Red)!},
            {typeof(Empty), (" ", ConsoleColor.White)},
            {typeof(Exit), ("▒", ConsoleColor.Magenta)},
            {typeof(Key), ((element as Key)?.Letter.ToString(), ConsoleColor.Green)!},
            {typeof(Player), ("¤", ConsoleColor.Blue)},
            {typeof(Wall), ("█", ConsoleColor.White)},
        };
        
        var (symbol, color) = elementSymbolDictionary[element.GetType()];
        
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
