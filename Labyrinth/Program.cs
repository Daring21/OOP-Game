using System;
using Labyrinth.Models;

namespace Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(20, 10, new Player(3, 3));
            Console.CursorVisible = false;

            game.AddElementToField(new Door(7, 7));

            game.AddElementToField(new Key(15, 5));

            game.AddElementToField(new Wall(1, 4));
            game.AddElementToField(new Wall(2, 5));
            game.AddElementToField(new Wall(3, 6));
            game.AddElementToField(new Wall(4, 7));

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

                Console.Clear();
                Console.CursorVisible = false;
                Helpers.DrawSymbolsOnTheMap();
                game.DrawField();
                currentKey = Console.ReadKey();
            }
        }
    }
}
