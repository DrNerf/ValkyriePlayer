using Common;
using Common.Events;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.PubSubEvents;
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

        private bool m_IsAppBusy = false;

        public bool IsAppBusy
        {
            get { return m_IsAppBusy; }
            set { SetProperty(ref m_IsAppBusy, value); }
        }


        public ShellViewModel(IEventAggregator eventAggregator)
        {
            string title = ConfigurationManager.AppSettings["gameTitle"];
            m_PlayerTitle = title == "default" ? Globals.DefaultTitle : title;
            eventAggregator.GetEvent<RaiseIsAppBusyEvent>().Subscribe(RaiseIsAppBusy);
        }

        private void RaiseIsAppBusy(bool obj)
        {
            IsAppBusy = obj;
        }
    }
}
