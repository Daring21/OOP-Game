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
        // foreach (var game in AllGamesList)
        // {
        //     
        // }

        CurrentLevel = new Level(AllGamesList[LevelIndex++], Form);
    }

    public void KeyPressed(Keys keys)
    {
        if (KeyDirectionsMap.ContainsKey(keys))
        {
            CurrentLevel.Game.MovePlayer(KeyDirectionsMap[keys]);
        }

        if (CurrentLevel.Game.GameInfo.IsGameOver)
        {
            if (LevelIndex == 1)
            {
                Form.Hide();
                var wonForm = new WonForm(LevelIndex);
                wonForm.Closed += (s, args) => Form.Close();
                wonForm.Show();
            }
            
            CurrentLevel = new Level(AllGamesList[LevelIndex++], Form);
        }
    }
}
