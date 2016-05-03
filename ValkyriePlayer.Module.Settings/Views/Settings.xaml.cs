﻿using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;
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
using ValkyriePlayer.Module.Settings.ViewModels;

namespace ValkyriePlayer.Module.Settings
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl, IView
    {
        public Settings(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            DataContext = new SettingsViewModel(eventAggregator);
        }
    }
}
