using Core;
using Core.Helpers;
using ConsoleApp.Helpers;
using Core.Models.GameElements;

namespace ConsoleApp;

public class Labyrinth
{
    private readonly Dictionary<ConsoleKey, Game.Directions> KeyDirectionsMap = new()
    {
        {ConsoleKey.UpArrow, Game.Directions.Top},
        {ConsoleKey.DownArrow, Game.Directions.Bottom},
        {ConsoleKey.LeftArrow, Game.Directions.Left},
        {ConsoleKey.RightArrow, Game.Directions.Right}
    };

    public void StartGame()
    {
        Console.CursorVisible = false;
        DrawHelper.DrawGreetingMessage();
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            Console.Clear();
            DrawHelper.DrawGreetingMessage();
        }

        SoundHelper.PlayMusic(Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Sounds/background.wav"));

        var levels = FileHelper.GetAllLevels("Assets/Levels/levels.json");
        var games = GameHelpers.CreateGamesFromJsonLevels(levels);
        foreach (var game in games)
        {
            Console.Clear();
            GameElement.DrawEvent += DrawHelper.DrawElement;
            game.DrawField();
            DrawHelper.DrawMessageFromFile(@"Assets/Messages/symbols.txt", ConsoleColor.Cyan);
            do
            {
                var currentKey = Console.ReadKey(true);
                Console.CursorVisible = false;
                if (KeyDirectionsMap.ContainsKey(currentKey.Key))
                {
                    game.MovePlayer(KeyDirectionsMap[currentKey.Key]);
                }
            } while (!game.GameInfo.IsGameOver);
        }

        Console.Clear();
        SoundHelper.PlaySounds(Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Sounds/achieve.wav"));
        DrawHelper.DrawMessageFromFile(@"Assets/Messages/won.txt", ConsoleColor.Green);
        Console.ReadLine();
    }
}