﻿using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
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
using ValkyriePlayer.Module.Main.ViewModels;

namespace ValkyriePlayer.Module.Main
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl, IView, INavigationAware, IRegionMemberLifetime
    {
        public Settings(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            InitializeComponent();
            DataContext = new SettingsViewModel(eventAggregator, regionManager);
        }

        public bool KeepAlive
        {
            get
            {
                return true;
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return navigationContext.Uri.LocalPath == "Browser";
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }
}
