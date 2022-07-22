using Core.Helpers;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SoundHelper.PlayMusic(Path.Combine(Directory.GetCurrentDirectory(), @"Assets/Sounds/background.wav"));
            Application.Run(new MainMenuForm());
        }
    }
}
