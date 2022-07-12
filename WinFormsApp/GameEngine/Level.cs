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
        AdjustPanelGameField();
        var drawHelper = new DrawHelper(Form);
        GameElement.DrawEvent += drawHelper.DrawElement;
        Game.DrawField();
    }

    private void AdjustPanelGameField()
    {
        Form.labelCollectedKeys.Text = "🗝 Collected Keys:";
        Form.panelGameField.Controls.Clear();
        Form.panelGameField.Size = new Size(Game.Field.GetLength(1) * 30, Game.Field.GetLength(0) * 30);
        Form.panelGameField.Left = (Form.panelGameField.Parent.Width - Form.panelGameField.Width) / 2;
        Form.panelGameField.Top = (Form.panelGameField.Parent.Height - Form.panelGameField.Height) / 2;
    }
}
