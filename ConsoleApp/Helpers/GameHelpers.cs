using ConsoleApp.Models;
using ConsoleApp;

namespace ConsoleApp.Helpers;

public static class GameHelpers
{
    public static List<Game> CreateGamesFromJsonLevels(JsonLevels levels)
    {
        var games = new List<Game>();

        foreach (var level in levels.Levels)
        {
            var currentGame = new Game(level.Width, level.Height, new Player(level.PlayerX, level.PlayerY));
        
            for (var y = 0; y < level.Scheme.Count; y++)
            {
                for (var x = 0; x < level.Scheme[y].Count; x++)
                {
                    var str = level.Scheme[y][x];

                    if (str.Length == 1)
                    {
                        var symbol = str[0];
                        if (char.IsLetter(symbol))
                        {
                            if (char.IsUpper(symbol))
                            {
                                currentGame.AddElementToField(new Door(x + 1, y + 1, char.ToLower(symbol)));
                            }
                            else
                            {
                                currentGame.AddElementToField(new Key(x + 1, y + 1, char.ToLower(symbol)));
                            }
                        }
                    }
                    if (str == "█")
                    {
                        currentGame.AddElementToField(new Wall(x + 1, y + 1));
                    }
                    if (str == "▒")
                    {
                        currentGame.AddElementToField(new Exit(x + 1, y + 1));
                    }
                }
            }
            
            games.Add(currentGame);
        }
        
        return games;
    }
}
