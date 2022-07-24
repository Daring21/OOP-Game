namespace Core.Models;

public class GameInfo
{
    public List<char> PlayerKeys { get; } = new();
    public List<char> RemainingDoors { get; set; } = new();
    public bool IsGameOver { get; set; }
}
