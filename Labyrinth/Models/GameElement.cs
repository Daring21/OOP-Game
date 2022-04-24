namespace Labyrinth.Models;

public abstract class GameElement
{
    public int X { get; set; }
    public int Y { get; set; }

    protected GameElement(int x, int y)
    {
        X = x;
        Y = y;
    }

    public abstract void Draw();
}