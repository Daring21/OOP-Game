using Core.Models.GameElements;

namespace Core;

public class Field
{
    public GameElement[,] field { get; }
    public int Height { get; }
    public int Width { get; }

    public GameElement this[int i, int j]
    {
        get => field[i, j];
        set
        {
            field[i, j] = value;
            field[i, j].Draw();
        }
    }

    public Field(int height, int width)
    {
        Height = height;
        Width = width;
        field = new GameElement[height, width];
    }
}
