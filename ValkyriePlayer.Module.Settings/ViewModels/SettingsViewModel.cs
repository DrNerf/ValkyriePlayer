using Common;
using Common.Events;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ValkyriePlayer.Module.Main.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
        private IEventAggregator m_eventAggregator;
        private IRegionManager m_regionManager;

        public List<string> Resolutions { get; set; }

        private string m_SplashImage;

        public string SplashImage
        {
            get { return m_SplashImage; }
            set 
            { 
                m_SplashImage = value;
                SetProperty(ref m_SplashImage, value);
                OnPropertyChanged("SplashImageBitmap");
            }
        }

        public DelegateCommand PlayCommand { get; set; }

        public SettingsViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            m_eventAggregator = eventAggregator;
            m_regionManager = regionManager;
            Resolutions = Globals.GetAvailableResolutions()
                .Reverse()
                .ToList();

            string splashImage = ConfigurationManager.AppSettings["splashImage"];
            SplashImage = splashImage == "default" ? AppDomain.CurrentDomain.BaseDirectory + Globals.DefaultSplashImage : splashImage;
            PlayCommand = new DelegateCommand(PlayButtonPressed);
        }

        private void PlayButtonPressed()
        {
            //m_eventAggregator.GetEvent<RaiseIsAppBusyEvent>().Publish(true);
            IRegion region = m_regionManager.Regions.First();
            var uri = new Uri("Browser", UriKind.Relative);
            region.RequestNavigate(uri);
        }
    }
}
