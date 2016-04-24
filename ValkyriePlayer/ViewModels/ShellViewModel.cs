using Common;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValkyriePlayer.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private string m_PlayerTitle;

        public string PlayerTitle
        {
            get { return m_PlayerTitle; }
            set { m_PlayerTitle = value; }
        }

        public ShellViewModel()
        {
            string title = ConfigurationManager.AppSettings["gameTitle"];
            m_PlayerTitle = title == "default" ? Globals.DefaultTitle : title;
        }
    }
}
