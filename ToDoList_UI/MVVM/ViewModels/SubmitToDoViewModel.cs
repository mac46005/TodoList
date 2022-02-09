using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDo_ClassLib.Interfaces;
using ToDoList_UI.Core;

namespace ToDoList_UI.MVVM.ViewModels
{
    public class SubmitToDoViewModel : BaseViewModel<IToDoItem>
    {
        public event EventHandler<IToDoItem> SubmitToDoItemEvent;

        public SubmitToDoViewModel()
        {
            Submit = new RelayCommand(o =>
            {
                SubmitToDoItemEvent?.Invoke(this, Model);
            });
        }

        public ICommand Submit { get; set; }
    }
}
