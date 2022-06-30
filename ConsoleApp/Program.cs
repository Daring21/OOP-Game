using ConsoleApp.Helpers;

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
                    switch (currentKey.Key)
                    {
                        case ConsoleKey.UpArrow:
                            game.MovePlayer(game.Player.X, game.Player.Y - 1);
                            break;
                        case ConsoleKey.DownArrow:
                            game.MovePlayer(game.Player.X, game.Player.Y + 1);
                            break;
                        case ConsoleKey.LeftArrow:
                            game.MovePlayer(game.Player.X - 1, game.Player.Y);
                            break;
                        case ConsoleKey.RightArrow:
                            game.MovePlayer(game.Player.X + 1, game.Player.Y);
                            break;
                    }
                    
                    // Console.Clear();
                    Console.CursorVisible = false;
                    // DrawHelper.DrawSymbolsOnTheMap();
                    // game.DrawField();
                } while (!game.IsGameOver);
            }
            
            Console.Clear();
            SoundHelper.PlayAchieveSound();
            DrawHelper.DrawWonMessage();
            Console.ReadLine();
        }
    }
}
