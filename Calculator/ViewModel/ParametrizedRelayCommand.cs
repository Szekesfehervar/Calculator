using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.ViewModel
{
    class ParametrizedRelayCommand : ICommand
    {
        Action<object> executeMethod;
        Func<bool> canexecuteMethod;
        public event EventHandler CanExecuteChanged;

        public ParametrizedRelayCommand(Action<object> executeMethod)
        {
            this.executeMethod = executeMethod;
            this.canexecuteMethod = canexecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
