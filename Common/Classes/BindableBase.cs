using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public void SetProperty(object value, ref object property, [CallerMemberName]string propName = "")
        {
            if (!value.Equals(property))
            {
                property = value;
                var propChanged = PropertyChanged;
                if (propChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propName));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
