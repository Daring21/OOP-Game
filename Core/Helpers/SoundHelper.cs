using System.Media;

namespace Core.Helpers;

public static class SoundHelper
{
    public static void PlayAchieveSound()
    {
        var soundLocation = Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Sounds/achieve.wav");
        using var player = new SoundPlayer(soundLocation);
        player.Play();
    }

    public static void PlayBackgroundSound()
    {
        var soundLocation = Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Sounds/background.wav");
        using var player = new SoundPlayer(soundLocation);
        player.PlayLooping();
    }
}
