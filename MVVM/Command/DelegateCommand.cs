using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.Command
{
    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc==null)
            {
                return true;
            }
            return CanExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (this.ExcuteAction != null)
            {
                ExcuteAction(parameter);
            }
        }
        public Action<object> ExcuteAction { get; set; }
        public Func<object,bool> CanExecuteFunc { get; set; }
    }
}
