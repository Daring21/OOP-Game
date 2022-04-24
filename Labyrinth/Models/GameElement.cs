namespace Labyrinth.Models;

public abstract class GameElement
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();
}
