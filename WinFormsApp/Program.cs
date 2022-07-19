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
            SoundHelper.PlayBackgroundSound();
            Application.Run(new MainMenuForm());
        }
    }
}
