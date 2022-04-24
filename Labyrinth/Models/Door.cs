namespace Labyrinth.Models;

public class Door : GameElement
{
    public Door(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        Console.Write("▒");
    }
}