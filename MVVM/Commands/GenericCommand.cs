using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_SimpleApp_Multiple_Command_Parameters.MVVM.Commands
{
    public class GenericCommand:ICommand
    {
        private Func<object, bool> _canExecute;
        private Action<object> _execute;

        public event EventHandler CanExecuteChanged
        {
            add {CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}

        }
        public GenericCommand(Func<object, bool> canExecute, Action<object> execute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {
            return this._canExecute == null || this._canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
    }
}
