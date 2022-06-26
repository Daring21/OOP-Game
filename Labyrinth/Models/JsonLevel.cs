namespace Labyrinth.Models;

public class JsonLevel
{
    public List<List<char>> Scheme { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int PlayerX { get; set; }
    public int PlayerY { get; set; }
}
