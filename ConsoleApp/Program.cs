using Core;
using Core.Helpers;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DrawHelper.DrawGreetingMessage();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.Clear();
                DrawHelper.DrawGreetingMessage();
            }
            // SoundHelper.PlayBackgroundSound();

            var levels = FileHelper.GetAllLevels("Assets/Levels/levels.json");
            var games = GameHelpers.CreateGamesFromJsonLevels(levels);
            foreach (var game in games)
            {
                Console.Clear();
                game.DrawField();
                DrawHelper.DrawSymbolsOnTheMap();
                do
                {
                    var currentKey = Console.ReadKey();
                    Console.CursorVisible = false;
                    switch (currentKey.Key)
                    {
                        case ConsoleKey.UpArrow:
                            game.MovePlayer(Game.Directions.Top);
                            break;
                        case ConsoleKey.DownArrow:
                            game.MovePlayer(Game.Directions.Bottom);
                            break;
                        case ConsoleKey.LeftArrow:
                            game.MovePlayer(Game.Directions.Left);
                            break;
                        case ConsoleKey.RightArrow:
                            game.MovePlayer(Game.Directions.Right);
                            break;
                    }
                } while (!game.IsGameOver);
            }
            
            Console.Clear();
            SoundHelper.PlayAchieveSound();
            DrawHelper.DrawWonMessage();
            Console.ReadLine();
        }
    }
}
