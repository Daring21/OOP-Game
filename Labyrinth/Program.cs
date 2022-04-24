using System;
using Labyrinth.Models;

namespace Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(10, 20);

            game.AddElementToField(new Player(3, 3));

            game.AddElementToField(new Door(7, 10));

            game.AddElementToField(new Key(5, 15));

            game.AddElementToField(new Wall(1, 4));
            game.AddElementToField(new Wall(2, 5));
            game.AddElementToField(new Wall(3, 6));
            game.AddElementToField(new Wall(4, 7));
            
            game.DrawField();
        }
    }
}
