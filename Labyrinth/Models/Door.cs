namespace Labyrinth.Models;

public class Door : GameElement
{
    public char Letter { get; set; }
    
    public Door(int x, int y, char letter) : base(x, y)
    {
        Letter = char.ToLower(letter);
    }

    public override void Draw()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        // Console.Write("▒");
        Console.Write(char.ToUpper(Letter));
        Console.ForegroundColor = previousColor;
    }
}
