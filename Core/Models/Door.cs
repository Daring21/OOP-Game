namespace Core.Models;

public class Door : GameElement
{
    public char Letter { get; set; }
    
    public Door(int x, int y, char letter) : base(x, y)
    {
        Letter = char.ToLower(letter);
    }
}
