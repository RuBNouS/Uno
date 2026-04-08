using System.Windows;
using UnoDesktopGame.Views;
using UnoDesktopGame.ViewModels;

namespace UnoDesktopGame
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow();
            mainWindow.DataContext = new MainViewModel(); // Injeta o ViewModel Principal
            mainWindow.Show();
        }
    }
}