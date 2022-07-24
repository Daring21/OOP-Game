namespace Core.Models.GameElements;

public class Door : GameElement
{
    public char Letter { get; set; }

    public Door(int x, int y, char letter) : base(x, y)
    {
        Letter = char.ToLower(letter);
    }

    public Door(Coords coords, char letter) : base(coords)
    {
        Letter = char.ToLower(letter);
    }

    public override bool IfCellIsMovable(GameInfo gameInfo)
    {
        return gameInfo.PlayerKeys.Contains(Letter);
    }

    public override void DoFunctionality(GameInfo gameInfo)
    {
        gameInfo.RemainingDoors = gameInfo.RemainingDoors.Where(doorLetter => Letter != doorLetter).ToList();
    }
}
