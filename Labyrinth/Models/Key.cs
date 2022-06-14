namespace Labyrinth.Models;

public class Key : GameElement
{
    public char Letter { get; set; }

    public Key(int x, int y, char letter) : base(x, y)
    {
        Letter = char.ToLower(letter);
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        // Console.Write("╒");
        Console.Write(Letter);
        Console.ForegroundColor = previousColor;
    }
}
