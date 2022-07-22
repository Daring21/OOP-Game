using WMPLib;

namespace Core.Helpers;

public static class SoundHelper
{
    private static readonly WindowsMediaPlayer MusicPlayer = new();
    private static readonly WindowsMediaPlayer SoundsPlayer = new();
    public static int MusicVolume
    {
        get => MusicPlayer.settings.volume;
        set => MusicPlayer.settings.volume = value;
    }
    public static int SoundsVolume
    {
        get => SoundsPlayer.settings.volume;
        set => SoundsPlayer.settings.volume = value;
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
