using ConsoleApp.Models;

namespace ConsoleApp;

public class Game
{
    public Player Player { get; private set; }
    public bool IsGameOver { get; private set; }
    private GameElement[,] Field { get; set; }
    private GameElement this[int i, int j]
    {
        get => Field[i, j];
        set => Field[i, j] = value;
    }
    private List<char> PlayerKeys { get; set; } = new();

    public Game(int width, int height, Player player)
    {
        Field = new GameElement[height, width];
        for (var y = 0; y < Field.GetLength(0); y++)
        {
            for (var x = 0; x < Field.GetLength(1); x++)
            {
                if (y == 0 || y == height - 1)
                {
                    this[y, x] = new Wall(y, x);
                }
                else if ((x == 0 || x == width - 1))
                {
                    this[y, x] = new Wall(y, x);
                }
                else
                {
                    this[y, x] = new Empty(y, x);
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
            }

            Console.WriteLine();
        }
    }

    public void MovePlayer(int newX, int newY)
    {
        if (IfCellIsMovable(newX, newY))
        {
            this[Player.Y, Player.X] = new Empty(Player.X, Player.Y);
            Console.SetCursorPosition(Player.X, Player.Y);
            this[Player.Y, Player.X].Draw();
            
            Player.X = newX;
            Player.Y = newY;
            this[newY, newX] = Player;
            Console.SetCursorPosition(newX, newY);
            this[newY, newX].Draw();
        }
        Console.SetCursorPosition(0, Field.GetLength(0) + 2);
    }

    private bool IfCellIsMovable(int x, int y)
    {
        if (this[y, x].GetType() == typeof(Empty))
        {
            return true;
        }
        
        if (this[y, x].GetType() == typeof(Key))
        {
            var keyLetter = ((Key) this[y, x]).Letter;
            PlayerKeys.Add(keyLetter);
            return true;
        }
        
        if (this[y, x].GetType() == typeof(Door))
        {
            var doorLetter = ((Door) this[y, x]).Letter;
            return PlayerKeys.Contains(doorLetter);
        }
        
        if (this[y, x].GetType() == typeof(Exit))
        {
            IsGameOver = true;
            return true;
        }

        return false;
    }
}
