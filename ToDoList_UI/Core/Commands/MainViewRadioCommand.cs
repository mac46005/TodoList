using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoList_UI.Core.Commands
{
    internal class MainViewRadioCommand : ICommand
    {
        Action<object> _execute;
        Func<bool, bool> _canExecute;



        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public MainViewRadioCommand(Action<object> execute,Func<object,bool> canExecute = null)
        {

        }


        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
