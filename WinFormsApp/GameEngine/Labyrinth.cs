using Core;
using Core.Helpers;
using Core.Models;
using WinFormsApp.Helpers;

namespace WinFormsApp.GameEngine;

public class Labyrinth
{
    private GameForm Form { get; }
    private Level CurrentLevel { get; set; }
    private List<Game> AllGamesList { get; set; }
    private int LevelIndex { get; set; } = 0;
    private readonly Dictionary<Keys, Game.Directions> KeyDirectionsMap = new ()
    {
        {Keys.Up, Game.Directions.Top},
        {Keys.Down, Game.Directions.Bottom},
        {Keys.Left, Game.Directions.Left},
        {Keys.Right, Game.Directions.Right}
    };

    public Labyrinth(GameForm form)
    {
        Form = form;
    }
    
    public void StartGame()
    {
        SoundHelper.PlayBackgroundSound();
        var levels = FileHelper.GetAllLevels("Assets/Levels/levels.json");
        AllGamesList = GameHelpers.CreateGamesFromJsonLevels(levels);
        CurrentLevel = new Level(AllGamesList[LevelIndex++], Form);
    }

    public void KeyPressed(Keys keys)
    {
        Form.labelCollectedKeys.Text = $"🗝 Collected Keys: {string.Join(", ", CurrentLevel.Game.GameInfo.PlayerKeys)}";

        if (KeyDirectionsMap.ContainsKey(keys))
        {
            CurrentLevel.Game.MovePlayer(KeyDirectionsMap[keys]);
        }

        if (CurrentLevel.Game.GameInfo.IsGameOver)
        {
            if (LevelIndex == AllGamesList.Count)
            {
                Form.Hide();
                var wonForm = new WonForm(LevelIndex);
                wonForm.Closed += (s, args) => Form.Close();
                wonForm.Show();
                return;
            }

            CurrentLevel = new Level(AllGamesList[LevelIndex++], Form);
        }
    }
}
