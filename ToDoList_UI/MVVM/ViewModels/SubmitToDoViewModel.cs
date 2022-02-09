using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;
using ToDoList_UI.Core;

namespace ToDoList_UI.MVVM.ViewModels
{
    public class SubmitToDoViewModel : ObservableObject, IViewModel<IToDoItem>
    {
        public event EventHandler<IToDoItem> SubmitToDoItemEvent;

        public SubmitToDoViewModel()
        {
            Submit = new RelayCommand();
        }

        public ICommand Submit { get; set; }
    }
}
