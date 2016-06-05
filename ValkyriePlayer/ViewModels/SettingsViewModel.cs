using Common.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValkyriePlayer.Classes;
using ValkyriePlayer.Views;

namespace ValkyriePlayer.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
        public ObservableCollection<string> Resolutions { get; set; }
        public DelegateCommand PlayCommand { get; set; }

        public SettingsViewModel()
        {
            Resolutions = new ObservableCollection<string>(Globals.GetAvailableResolutions().Reverse());
            PlayCommand = new DelegateCommand(PlayButton);
        }

        private void PlayButton()
        {
            Navigator.Navigate(typeof(Busy));
        }


    }
}
