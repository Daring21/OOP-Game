﻿namespace Labyrinth.Models;

public class Empty : GameElement
{
    public Empty(int x, int y) : base(x, y)
    {
    }

    public override void Draw()
    {
        Console.Write(" ");
    }
}