namespace Labyrinth.Models;

public class Door : GameElement
{
    public Door(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("▒");
        Console.ForegroundColor = previousColor;
    }
}
