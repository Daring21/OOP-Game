namespace Labyrinth.Models;

public class Player : GameElement
{
    public Player(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        Console.Write("o");
    }
}