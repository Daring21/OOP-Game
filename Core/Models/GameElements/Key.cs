using Core.Helpers;

namespace Core.Models.GameElements;

public class Key : GameElement
{
    public char Letter { get; set; }

    public Key(int x, int y, char letter) : base(x, y)
    {
        Letter = char.ToLower(letter);
    }
    public Key(Coords coords, char letter) : base(coords)
    {
        Letter = char.ToLower(letter);
    }

    public override bool IfCellIsMovable(GameInfo gameInfo)
    {
        return true;
    }

    public override void DoFunctionality(GameInfo gameInfo)
    {
        gameInfo.PlayerKeys.Add(Letter);
        SoundHelper.PlayAchieveSound();
    }
}
