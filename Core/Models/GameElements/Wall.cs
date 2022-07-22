namespace Core.Models.GameElements;

public class Wall : GameElement
{
    public Wall(int x, int y) : base(x, y)
    {
    }
    public Wall(Coords coords) : base(coords)
    {
    }

    public override bool IfCellIsMovable(GameInfo gameInfo)
    {
        return false;
    }

    public override void DoFunctionality(GameInfo gameInfo)
    {
    }
}
