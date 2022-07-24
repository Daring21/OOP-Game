using Core.Models;
using Core.Models.GameElements;
using Core.Models.Json;

namespace Core.Helpers;

public static class GameHelpers
{
    private static Dictionary<string, Type> symbolElements = new()
    {
        {"█", typeof(Wall)},
        {"▒", typeof(Exit)},
        {"¤", typeof(Player)},
    };

    public static List<Game> CreateGamesFromJsonLevels(JsonLevels levels)
    {
        return levels.Levels.Select(level => FillGameWithLevel(level)).ToList();
    }

    private static Game FillGameWithLevel(JsonLevel level)
    {
        var game = new Game(level.Width, level.Height, new Player(level.PlayerX, level.PlayerY));
        game.AddBorderToGame();
        for (var y = 0; y < level.Scheme.Count; y++)
        {
            for (var x = 0; x < level.Scheme[y].Count; x++)
            {
                var coords = new Coords(x + 1, y + 1);
                var str = level.Scheme[y][x];
                game.AddElementToField(CreateElementBySymbol(str, coords));
            }
        }

        return game;
    }

    private static GameElement CreateElementBySymbol(string str, Coords coords)
    {
        if (symbolElements.ContainsKey(str))
        {
            return (Activator.CreateInstance(symbolElements[str], coords) as GameElement)!;
        }

        var symbol = str[0];
        if (char.IsLetter(symbol))
        {
            if (char.IsUpper(symbol))
            {
                return new Door(coords, char.ToLower(symbol));
            }
            else
            {
                return new Key(coords, char.ToLower(symbol));
            }
        }

        return new Empty(coords);
    }
}

public static class GameExtension
{
    public static void AddBorderToGame(this Game game)
    {
        var height = game.Field.Height;
        var width = game.Field.Width;
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                if (y == 0 || y == height - 1)
                {
                    game.Field[y, x] = new Wall(x, y);
                }
                else if (x == 0 || x == width - 1)
                {
                    game.Field[y, x] = new Wall(x, y);
                }
            }
        }
    }
}