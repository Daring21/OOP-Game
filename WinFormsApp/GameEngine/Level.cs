using Core;
using Core.Models;
using WinFormsApp.Helpers;

namespace WinFormsApp.GameEngine;

public class Level
{
    public Game Game { get; }
    public GameForm Form { get; set; }
    
    public Level(Game game, GameForm form)
    {
        Game = game;
        Form = form;
        StartLevel();
    }

    public void StartLevel()
    {
        Form.panel1.Controls.Clear();
        Form.panel1.Size = new Size(Game.Field.GetLength(1) * 30, Game.Field.GetLength(0) * 30);
        Form.panel1.Left = (Form.panel1.Parent.Width - Form.panel1.Width) / 2;
        Form.panel1.Top = (Form.panel1.Parent.Height - Form.panel1.Height) / 2;

        var drawHelper = new DrawHelper(Form);
            
        GameElement.DrawEvent += drawHelper.DrawElement;
        Game.DrawField();
    }
}
