namespace Core.Models;

public class Empty : GameElement
{
    public Empty(int x, int y) : base(x, y)
    {
    }
    public Empty(Coords coords) : base(coords)
    {
    }

    public override bool IfCellIsMovable(GameInfo gameInfo)
    {
        return true;
    }

    public override void DoFunctionality(GameInfo gameInfo)
    {
    }
}
