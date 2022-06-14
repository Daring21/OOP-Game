using System;
using Labyrinth.Models;

namespace Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Helpers.DrawGreetingMessage();
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.Clear();
                Helpers.DrawGreetingMessage();
            }
            
            Helpers.PlayBackgroundSound();
            var currentKey = new ConsoleKeyInfo();
            while (true)
            {
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
                Helpers.DrawSymbolsOnTheMap();
                game.DrawField();
                currentKey = Console.ReadKey();
            }
            
            Console.Clear();
            Helpers.PlayAchieveSound();
            Helpers.DrawWonMessage();
            Console.ReadLine();
        }
    }
}
