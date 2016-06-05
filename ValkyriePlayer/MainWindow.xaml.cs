using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValkyriePlayer.Classes;
using ValkyriePlayer.Views;

namespace ValkyriePlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigator.Init(SetContent);
            Navigator.Navigate(typeof(Settings));
        }

        private void SetContent(UserControl obj)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                ContentWrapper.Children.Clear();
                ContentWrapper.Children.Add(obj);
            }));
        }
    }
}
