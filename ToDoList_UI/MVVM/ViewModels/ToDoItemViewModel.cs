using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using ToDo_ClassLib.Models;

namespace ToDoList_UI.MVVM.ViewModels
{
    /// <summary>
    /// Single ToDoItem viewmodel
    /// </summary>
    public class ToDoItemViewModel : BaseViewModel<ToDoItem>
    {
        DispatcherTimer _timer;
        public ToDoItemViewModel()
        {
            SubmitToDoViewModel.SubmitToDoItemEvent += SubmitToDoViewModel_SubmitToDoItemEvent;
        }







        private void SubmitToDoViewModel_SubmitToDoItemEvent(object? sender, ToDo_ClassLib.Interfaces.IToDoItem e)
        {
            /// Submit to database
            /// 

        }



        public SubmitToDoViewModel SubmitToDoViewModel { get; set;} = new SubmitToDoViewModel();

    }
}
