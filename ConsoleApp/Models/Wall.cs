namespace ConsoleApp.Models;

public class Wall : GameElement
{
    public Wall(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        Console.Write("█");
    }
}