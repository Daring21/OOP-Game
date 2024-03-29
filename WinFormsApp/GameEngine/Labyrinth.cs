﻿using Core;
using Core.Helpers;
using WinFormsApp.Helpers;

namespace WinFormsApp.GameEngine;

public class Labyrinth
{
    private GameForm Form { get; }
    private Level CurrentLevel { get; set; }
    private List<Game> AllGamesList { get; set; }
    private int LevelIndex { get; set; } = 0;

    private readonly Dictionary<Keys, Game.Directions> _keyDirectionsMap = new()
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
        var levels = FileHelper.GetAllLevels("Assets/Levels/levels.json");
        AllGamesList = GameHelpers.CreateGamesFromJsonLevels(levels);
        CurrentLevel = new Level(AllGamesList[LevelIndex], Form);
        Form.labelRemainingDoors.Text =
            DefaultText.LabelRemainingDoors + string.Join(", ", CurrentLevel.Game.GameInfo.RemainingDoors);
    }

    public void KeyPressed(Keys keys)
    {
        if (_keyDirectionsMap.ContainsKey(keys))
        {
            CurrentLevel.Game.MovePlayer(_keyDirectionsMap[keys]);
        }

        CheckForFunctionality();
    }

    private void CheckForFunctionality()
    {
        if (CurrentLevel.Game.GameInfo.IsGameOver)
        {
            if (LevelIndex == AllGamesList.Count - 1)
            {
                FormHelper.OpenForm(Form, new WonForm(LevelIndex + 1));
                return;
            }

            LevelIndex++;
            CurrentLevel = new Level(AllGamesList[LevelIndex], Form);
        }

        Form.labelCollectedKeys.Text =
            DefaultText.LabelCollectedKeys + string.Join(", ", CurrentLevel.Game.GameInfo.PlayerKeys);
        Form.labelRemainingDoors.Text =
            DefaultText.LabelRemainingDoors + string.Join(", ", CurrentLevel.Game.GameInfo.RemainingDoors);
    }
}
