using FRCDiagnostics.UI;
using FRCDiagnostics.UI.Themes;

namespace FRCDiagnostics
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ThemeManager theme = new(new DarkTheme());
            ThemeManager.Global = theme;
            Application.Run(new OverviewWindow());
        }
    }
}