namespace ConsoleApp.Models;

public class Exit : GameElement
{
    public Exit(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("▒");
        Console.ForegroundColor = previousColor;
    }
}
