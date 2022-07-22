namespace Core.Models;

public class GameInfo
{
    public List<char> PlayerKeys { get; } = new();
    public bool IsGameOver { get; set; }
}
