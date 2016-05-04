using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValkyriePlayer.Module.Main
{
    public class MainModule : IModule
    {
        private readonly IRegionViewRegistry m_RegionViewRegistry = null;

        public MainModule(IRegionViewRegistry regionViewRegistry)
        {
            m_RegionViewRegistry = regionViewRegistry;
        }

        public void Initialize()
        {
            m_RegionViewRegistry.RegisterViewWithRegion("MainRegion", typeof(Settings));
            m_RegionViewRegistry.RegisterViewWithRegion("MainRegion", typeof(Browser));
        }
    }
}
