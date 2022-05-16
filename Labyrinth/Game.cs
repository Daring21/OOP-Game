﻿using Labyrinth.Models;

namespace Labyrinth;

public class Game
{
    public Player Player { get; set; }
    private GameElement[,] Field { get; set; }
    private bool HasKey { get; set; }
    // private Dictionary<Door, Key> DoorAndKeys { get; set; }

    public Game(int width, int height, Player player)
    {
        Field = new GameElement[height, width];
        for (var y = 0; y < Field.GetLength(0); y++)
        {
            for (var x = 0; x < Field.GetLength(1); x++)
            {
                if (y == 0 || y == height - 1)
                {
                    Field[y, x] = new Wall(y, x);
                }
                else if ((x == 0 || x == width - 1))
                {
                    Field[y, x] = new Wall(y, x);
                }
                else
                {
                    Field[y, x] = new Empty(y, x);
                }
            }
        }
        
        Player = player;
        AddElementToField(player);
    }

    public void AddElementToField(GameElement gameElement)
    {
        // if (gameElement.GetType() == typeof(Door))
        // {
        // }
        Field[gameElement.Y, gameElement.X] = gameElement;
    }

    public void DrawField()
    {
        for (var y = 0; y < Field.GetLength(0); y++)
        {
            for (var x = 0; x < Field.GetLength(1); x++)
            {
                Field[y, x].Draw();
            }

            Console.WriteLine();
        }
    }

    public void MovePlayer(int newX, int newY)
    {
        if (IfCellIsMovable(newX, newY))
        {
            Field[Player.Y, Player.X] = new Empty(Player.X, Player.Y);
            Player = new Player(newX, newY);
            Field[newY, newX] = Player;
        }
    }
    
    private bool IfCellIsMovable(int x, int y)
    {
        if (Field[y, x].GetType() == typeof(Empty))
        {
            return true;
        }
        else if (Field[y, x].GetType() == typeof(Key))
        {
            HasKey = true;
            return true;
        }
        else if (Field[y, x].GetType() == typeof(Door))
        {
            return HasKey;
        }

        return false;
    }
}
