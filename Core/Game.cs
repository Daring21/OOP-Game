using Core.Models;
using Core.Models.GameElements;

namespace Core;

public class Game
{
    public enum Directions
    {
        Top,
        Left,
        Bottom,
        Right
    }

    public GameInfo GameInfo { get; }
    public Field Field { get; }
    private Player Player { get; }

    private Dictionary<Directions, (int, int)> Deltas { get; } = new()
    {
        {Directions.Top, (0, -1)},
        {Directions.Right, (1, 0)},
        {Directions.Bottom, (0, 1)},
        {Directions.Left, (-1, 0)}
    };

    public Game(int width, int height, Player player)
    {
        GameInfo = new GameInfo();
        Field = new Field(height, width);
        Player = player;
        AddElementToField(player);
    }

    public void AddElementToField(GameElement gameElement)
    {
        Field[gameElement.Y, gameElement.X] = gameElement;
        if (gameElement is Door door)
        {
            GameInfo.RemainingDoors.Add(door.Letter);
        }
    }

    public void DrawField()
    {
        for (var y = 0; y < Field.Height; y++)
        {
            for (var x = 0; x < Field.Width; x++)
            {
                Field[y, x].Draw();
                // Thread.Sleep(15);
            }
        }
    }

    public void MovePlayer(Directions direction)
    {
        var (deltaX, deltaY) = Deltas[direction];
        var newCords = new Coords(Player.X + deltaX, Player.Y + deltaY);

        Field[newCords.Y, newCords.X].DoFunctionality(GameInfo);

        var isMovable = Field[newCords.Y, newCords.X].IfCellIsMovable(GameInfo);
        if (isMovable)
        {
            Field[Player.Y, Player.X] = new Empty(Player.X, Player.Y);
            (Player.X, Player.Y) = (newCords.X, newCords.Y);
            Field[newCords.Y, newCords.X] = Player;
        }
    }
}
