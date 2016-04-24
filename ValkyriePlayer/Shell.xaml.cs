using System.Windows;
using ValkyriePlayer.ViewModels;

namespace ValkyriePlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
            DataContext = new ShellViewModel();
        }

        private void Thumb_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MinimizeApp(object sender, RoutedEventArgs e)
        {
            WindowState = System.Windows.WindowState.Minimized;
        }

        private void ShutdownApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
