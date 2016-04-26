using Common;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValkyriePlayer.Module.Settings.ViewModels
{
    public class SettingsViewModel : BindableBase
    {
        public List<string> Resolutions { get; set; }

        public SettingsViewModel()
        {
            Resolutions = Globals.GetAvailableResolutions()
                .Reverse()
                .ToList();
        }
    }
}
