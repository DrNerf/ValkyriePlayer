using Common;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ValkyriePlayer.Module.Settings.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
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

        public SettingsViewModel()
        {
            Resolutions = Globals.GetAvailableResolutions()
                .Reverse()
                .ToList();

            string splashImage = ConfigurationManager.AppSettings["splashImage"];
            SplashImage = splashImage == "default" ? AppDomain.CurrentDomain.BaseDirectory + Globals.DefaultSplashImage : splashImage;
        }
    }
}
