namespace Labyrinth.Models;

public class Player : GameElement
{
    public Player(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("¤");
        Console.ForegroundColor = previousColor;
    }
}
