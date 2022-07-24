using Core;
using Core.Models.GameElements;
using WinFormsApp.Helpers;

namespace WinFormsApp.GameEngine;

public class Level
{
    public Game Game { get; }
    private GameForm Form { get; set; }

    public Level(Game game, GameForm form)
    {
        Game = game;
        Form = form;
        StartLevel();
    }

    private void StartLevel()
    {
        ResetControls();
        var drawHelper = new DrawHelper(Form);
        GameElement.DrawEvent += drawHelper.DrawElement;
        Game.DrawField();
    }

    private void ResetControls()
    {
        var panelField = Form.panelGameField;
        Form.labelCollectedKeys.Text = DefaultText.LabelCollectedKeys;
        Form.labelRemainingDoors.Text = DefaultText.LabelRemainingDoors;
        panelField.Controls.Clear();
        panelField.Size = new Size(Game.Field.Width * 30, Game.Field.Height * 30);
        panelField.Left = (panelField.Parent.Width - panelField.Width) / 2;
        panelField.Top = (panelField.Parent.Height - panelField.Height) / 2;
    }
}
