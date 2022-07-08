namespace Core.Models;

public class Player : GameElement
{
    public Player(int x, int y) : base(x, y)
    {
    }
    public Player(Coords coords) : base(coords)
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
