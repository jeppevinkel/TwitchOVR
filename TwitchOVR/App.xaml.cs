using System.Windows;
using TwitchOVR.Models;
using TwitchOVR.ViewModels;

namespace TwitchOVR
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();
        }
    }
}