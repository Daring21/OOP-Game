namespace Core.Models;

public class Player : GameElement
{
    public Player(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.SetCursorPosition(X, Y);
        Console.Write("¤");
        Console.SetCursorPosition(0, 10);
        Console.ForegroundColor = previousColor;
    }
}
