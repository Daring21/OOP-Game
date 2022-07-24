namespace Core.Models.GameElements;

public class Exit : GameElement
{
    public Exit(int x, int y) : base(x, y)
    {
    }

    public Exit(Coords coords) : base(coords)
    {
    }

    public override bool IfCellIsMovable(GameInfo gameInfo)
    {
        return true;
    }

    public override void DoFunctionality(GameInfo gameInfo)
    {
        gameInfo.IsGameOver = true;
    }
}