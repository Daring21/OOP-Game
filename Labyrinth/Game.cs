using Labyrinth.Models;

namespace Labyrinth;

public class Game
{
    private GameElement[,] Field { get; set; }

    public Game(int width, int height)
    {
        Field = new GameElement[width, height];
        for (var x = 0; x < Field.GetLength(0); x++)
        {
            for (var y = 0; y < Field.GetLength(1); y++)
            {
                if (x == 0 || x == width - 1)
                {
                    Field[x, y] = new Wall(x, y);
                }
                else if ((y == 0 || y == height - 1))
                {
                    Field[x, y] = new Wall(x, y);
                }
                else
                {
                    Field[x, y] = new Empty(x, y);
                }
            }
        }
    }

    public void AddElementToField(GameElement gameElement)
    {
        Field[gameElement.X, gameElement.Y] = gameElement;
    }

    public void DrawField()
    {
        for (var y = 0; y < Field.GetLength(0); y++)
        {
            for (var x = 0; x < Field.GetLength(1); x++)
            {
                Field[y, x].Draw();
            }

            Console.WriteLine();
        }
    }
}
