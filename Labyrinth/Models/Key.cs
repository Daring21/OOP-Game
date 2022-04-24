namespace Labyrinth.Models;

public class Key : GameElement
{
    public Key(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        Console.Write("╒");
    }
}