using Core.Models;

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
    public GameElement[,] Field { get; }
    public GameElement this[int i, int j]
    {
        get => Field[i, j];
        set
        {
            Field[i, j] = value;
            Field[i, j].Draw();
        }
    }
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
        Field = new GameElement[height, width];
        Player = player;
        AddElementToField(player);
    }

    public void AddElementToField(GameElement gameElement)
    {
        this[gameElement.Y, gameElement.X] = gameElement;
    }

    public void DrawField()
    {
        for (var y = 0; y < Field.GetLength(0); y++)
        {
            for (var x = 0; x < Field.GetLength(1); x++)
            {
                this[y, x].Draw();
                // Thread.Sleep(15);
            }
        }
    }

    public void MovePlayer(Directions direction)
    {
        var (deltaX, deltaY) = Deltas[direction];
        var newCords = new Coords(Player.X + deltaX, Player.Y + deltaY);

        var isMovable = this[newCords.Y, newCords.X].IfCellIsMovable(GameInfo);
        this[newCords.Y, newCords.X].DoFunctionality(GameInfo);
        if (isMovable)
        {
            this[Player.Y, Player.X] = new Empty(Player.X, Player.Y);
            (Player.X, Player.Y) = (newCords.X, newCords.Y);
            this[newCords.Y, newCords.X] = Player;
        }
    }
}
