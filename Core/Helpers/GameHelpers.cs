﻿using Core.Models;

namespace Core.Helpers;

public static class GameHelpers
{
    public static List<Game> CreateGamesFromJsonLevels(JsonLevels levels)
    {
        var games = new List<Game>();

        foreach (var level in levels.Levels)
        {
            var currentGame = FillGameWithLevel(level);
            games.Add(currentGame);
        }
        
        return games;
    }

    private static Game FillGameWithLevel(JsonLevel level)
    {
        var game = new Game(level.Width, level.Height, new Player(level.PlayerX, level.PlayerY));
        game.AddBorderToGame();
        for (var y = 0; y < level.Scheme.Count; y++)
        {
            for (var x = 0; x < level.Scheme[y].Count; x++)
            {
                var coords = new Coords(x, y);
                var str = level.Scheme[y][x];
                game.AddElementToField(CreateElementBySymbol(str, coords));
            }
        }

        return game;
    }

    private static GameElement CreateElementBySymbol(string str, Coords coords)
    {
        if (str.Length == 1)
        {
            var symbol = str[0];
            if (char.IsLetter(symbol))
            {
                if (char.IsUpper(symbol))
                {
                    return new Door(coords.X + 1, coords.Y + 1, char.ToLower(symbol));
                }
                else
                {
                    return new Key(coords.X + 1, coords.Y + 1, char.ToLower(symbol));
                }
            }
        }
        if (str == "█")
        {
            return new Wall(coords.X + 1, coords.Y + 1);
        }
        if (str == "▒")
        {
            return new Exit(coords.X + 1, coords.Y + 1);
        }
        if (str == "¤")
        {
            return new Player(coords.X + 1, coords.Y + 1);
        }

        return new Empty(coords.X + 1, coords.Y + 1);
    }
}

public static class GameExtension
{
    public static void AddBorderToGame(this Game game)
    {
        var height = game.Field.GetLength(0);
        var width = game.Field.GetLength(1);
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                if (y == 0 || y == height- 1)
                {
                    game[y, x] = new Wall(x, y);
                }
                else if ((x == 0 || x == width  - 1))
                {
                    game[y, x] = new Wall(x, y);
                }
                else
                {
                    game[y, x] = new Empty(x, y);
                }
            }
        }
    }
}
