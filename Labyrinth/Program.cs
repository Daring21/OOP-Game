using System;
using Labyrinth.Helpers;
using Labyrinth.Models;

namespace Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allLevels = FileHelper.GetAllLevels(Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Levels/levels.json"));
            foreach (var level in allLevels.Levels)
            {
                var currentGame = new Game(level.Width, level.Height, new Player(level.PlayerX, level.PlayerY));

                for (var y = 0; y < level.Scheme.Count; y++)
                {
                    for (var x = 0; x < level.Scheme[y].Count; x++)
                    {
                        var symbol = level.Scheme[y][x];
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
                        else if (symbol == '█')
                        {
                            currentGame.AddElementToField(new Wall(x + 1, y + 1));
                        }
                        else if (symbol == '▒')
                        {
                            currentGame.AddElementToField(new Exit(x + 1, y + 1));
                        }
                        Console.Write(level.Scheme[y][x]);
                    }
                    Console.WriteLine();
                }
            }
            
            
            var game = new Game(17, 7, new Player(1, 1));
            Console.CursorVisible = false;
            
            game.AddElementToField(new Key(6, 1, 'a'));
            game.AddElementToField(new Door(10, 4, 'b'));
            game.AddElementToField(new Key(15, 5, 'b'));
            game.AddElementToField(new Door(5, 5, 'a'));
            
            game.AddElementToField(new Wall(2, 1));
            game.AddElementToField(new Wall(7, 1));
            game.AddElementToField(new Wall(2, 2));
            game.AddElementToField(new Wall(4, 2));
            game.AddElementToField(new Wall(5, 2));
            game.AddElementToField(new Wall(6, 2));
            game.AddElementToField(new Wall(7, 2));
            game.AddElementToField(new Wall(8, 2));
            game.AddElementToField(new Wall(9, 2));
            game.AddElementToField(new Wall(10, 2));
            game.AddElementToField(new Wall(12, 2));
            game.AddElementToField(new Wall(13, 2));
            game.AddElementToField(new Wall(14, 2));
            game.AddElementToField(new Wall(15, 2));
            game.AddElementToField(new Wall(5, 3));
            game.AddElementToField(new Wall(9,3));
            game.AddElementToField(new Wall(12, 3));
            game.AddElementToField(new Wall(14, 3));
            game.AddElementToField(new Wall(1, 4));
            game.AddElementToField(new Wall(2, 4));
            game.AddElementToField(new Wall(3, 4));
            game.AddElementToField(new Wall(5, 4));
            game.AddElementToField(new Wall(7, 4));
            game.AddElementToField(new Wall(9, 4));
            game.AddElementToField(new Wall(11, 4));
            game.AddElementToField(new Wall(12, 4));
            game.AddElementToField(new Wall(14, 4));
            game.AddElementToField(new Wall(7, 5));
            
            game.AddElementToField(new Exit(16, 1));

            DrawHelper.DrawGreetingMessage();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.Clear();
                DrawHelper.DrawGreetingMessage();
            }
            
            SoundHelper.PlayBackgroundSound();
            while (true)
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

                if (game.IsGameOver)
                {
                    break;
                }
                
                Console.Clear();
                Console.CursorVisible = false;
                DrawHelper.DrawSymbolsOnTheMap();
                game.DrawField();
            }
            
            Console.Clear();
            SoundHelper.PlayAchieveSound();
            DrawHelper.DrawWonMessage();
            Console.ReadLine();
        }
    }
}
