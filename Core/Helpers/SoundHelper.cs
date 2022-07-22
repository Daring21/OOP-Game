﻿using WMPLib;

namespace Core.Helpers;

public static class SoundHelper
{
    private static readonly WindowsMediaPlayer MusicPlayer = new();
    private static readonly WindowsMediaPlayer SoundsPlayer = new();
    private static int _musicVolume = 100;
    private static int _soundVolume = 100;
    public static int MusicVolume
    {
        get => _musicVolume;
        set
        {
            MusicPlayer.settings.volume = value;
            _musicVolume = value;
        }
    }
    public static int SoundsVolume
    {
        get => _soundVolume;
        set
        {
            SoundsPlayer.settings.volume = value;
            _soundVolume = value;
        }
    }

    public static void PlayMusic(string path)
    {
        MusicPlayer.URL = path;
        MusicPlayer.controls.play();
    }

    public static void PlaySounds(string path)
    {
        SoundsPlayer.URL = path;
        SoundsPlayer.controls.play();
    }
}
