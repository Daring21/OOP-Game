using Core;
using Core.Helpers;
using Core.Models;
using WinFormsApp.Helpers;

namespace WinFormsApp;

public class Labyrinth
{
    private Form2 Form { get; }
    private Game CurrentGame { get; set; }
    private readonly Dictionary<Keys, Game.Directions> KeyDirectionsMap = new ()
    {
        {Keys.Up, Game.Directions.Top},
        {Keys.Down, Game.Directions.Bottom},
        {Keys.Left, Game.Directions.Left},
        {Keys.Right, Game.Directions.Right}
    };

    public Labyrinth(Form2 form)
    {
        Form = form;
    }
    
    public void StartGame()
    {
        // SoundHelper.PlayBackgroundSound();
        var levels = FileHelper.GetAllLevels("Assets/Levels/levels.json");
        var games = GameHelpers.CreateGamesFromJsonLevels(levels);
        foreach (var game in games)
        {
            CurrentGame = game;
            Form.panel1.Controls.Clear();
            Form.panel1.Size = new Size(CurrentGame.Field.GetLength(1) * 30, CurrentGame.Field.GetLength(0) * 30);
            Form.panel1.Left = (Form.panel1.Parent.Width - Form.panel1.Width) / 2;
            Form.panel1.Top = (Form.panel1.Parent.Height - Form.panel1.Height) / 2;

            var drawHelper = new DrawHelper(Form);
            
            GameElement.DrawEvent += drawHelper.DrawElement;
            game.DrawField();
        }
    }

    public void KeyPressed(Keys keys)
    {
        if (KeyDirectionsMap.ContainsKey(keys))
        {
            CurrentGame.MovePlayer(KeyDirectionsMap[keys]);
        }

        if (CurrentGame.GameInfo.IsGameOver)
        {
            StartGame();
        }
    }
}
