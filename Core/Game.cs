using Core.Models;

namespace Core;

public class Game
{
    public bool IsGameOver { get; private set; }
    public enum Directions
    {
        Top,
        Left,
        Bottom,
        Right
    }
    private GameElement[,] Field { get; }
    private GameElement this[int i, int j]
    {
        get => Field[i, j];
        set => Field[i, j] = value;
    }
    private Player Player { get; }
    private List<char> PlayerKeys { get; } = new();
    private Dictionary<Directions, (int, int)> Deltas { get; } = new()
    {
        {Directions.Top, (0, -1)},
        {Directions.Right, (1, 0)},
        {Directions.Bottom, (0, 1)},
        {Directions.Left, (-1, 0)}
    };

    public Game(int width, int height, Player player)
    {
        Field = new GameElement[height, width];
        for (var y = 0; y < Field.GetLength(0); y++)
        {
            for (var x = 0; x < Field.GetLength(1); x++)
            {
                if (y == 0 || y == height - 1)
                {
                    this[y, x] = new Wall(x, y);
                }
                else if ((x == 0 || x == width - 1))
                {
                    this[y, x] = new Wall(x, y);
                }
                else
                {
                    this[y, x] = new Empty(x, y);
                }
            }
        }

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
                Thread.Sleep(15);
            }
        }
    }

    public void MovePlayer(Directions direction)
    {
        var (newX, newY) = Deltas[direction];
        newX = Player.X + newX;
        newY = Player.Y + newY;
        if (IfCellIsMovable(newX, newY))
        {
            this[Player.Y, Player.X] = new Empty(Player.X, Player.Y);
            this[Player.Y, Player.X].Draw();
            Player.X = newX;
            Player.Y = newY;
            this[newY, newX] = Player;
            this[newY, newX].Draw();
        }
    }

    private bool IfCellIsMovable(int x, int y)
    {
        if (this[y, x] is Empty)
        {
            return true;
        }
        
        if (this[y, x] is Key)
        {
            var keyLetter = ((Key) this[y, x]).Letter;
            PlayerKeys.Add(keyLetter);
            return true;
        }
        
        if (this[y, x] is Door)
        {
            var doorLetter = ((Door) this[y, x]).Letter;
            return PlayerKeys.Contains(doorLetter);
        }
        
        if (this[y, x] is Exit)
        {
            IsGameOver = true;
            return true;
        }

        return false;
    }
}
