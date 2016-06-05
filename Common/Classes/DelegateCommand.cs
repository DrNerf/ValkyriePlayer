using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Common.Classes
{
    public class DelegateCommand<T> : ICommand
    {
        private Action<T> m_Execute;
        private Func<bool> m_CanExecute;

        public DelegateCommand(Action<T> execute, Func<bool> canExecute = null)
        {
            m_Execute = execute;
            m_CanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if(m_CanExecute != null)
                return m_CanExecute();
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            m_Execute((T)parameter);
        }
    }

    public class DelegateCommand : DelegateCommand<object>
    {
        public DelegateCommand(Action execute, Func<bool> canExecute = null)
            : base((object placeHolder) => { execute(); }, canExecute)
        {

        }
    }
}
