namespace Core.Models;

public abstract class GameElement
{
    public int X { get; set; }
    public int Y { get; set; }
    public static event EventHandler? DrawEvent;
    
    protected GameElement(int x, int y)
    {
        X = x;
        Y = y;
    }
    protected GameElement(Coords coords)
    {
        X = coords.X;
        Y = coords.Y;
    }

    public void Draw()
    {
        DrawEvent?.Invoke(this, EventArgs.Empty);
    }

    public abstract bool IfCellIsMovable(GameInfo gameInfo);
    
    public abstract void DoFunctionality(GameInfo gameInfo);
}
