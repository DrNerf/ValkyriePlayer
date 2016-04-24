using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValkyriePlayer.Module.Settings
{
    public class SettingsModule : IModule
    {
        private readonly IRegionViewRegistry m_RegionViewRegistry = null;

        public SettingsModule(IRegionViewRegistry regionViewRegistry)
        {
            m_RegionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            m_RegionViewRegistry.RegisterViewWithRegion("SettingsRegion", typeof(Settings));
        }
    }
}
