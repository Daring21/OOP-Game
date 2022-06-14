namespace Labyrinth.Models;

public class Key : GameElement
{
    public Key(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("╒");
        Console.ForegroundColor = previousColor;
    }
}
