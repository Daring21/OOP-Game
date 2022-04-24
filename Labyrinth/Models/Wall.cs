namespace Labyrinth.Models;

public class Wall : GameElement
{
    public override void Draw()
    {
        Console.Write("█");
    }
}
