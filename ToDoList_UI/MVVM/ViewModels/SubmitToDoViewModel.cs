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
    /// <summary>
    /// The submission form on the ToDoMainViewModel.
    /// Used for creating a new ITodoItem
    /// </summary>
    public class SubmitToDoViewModel : BaseViewModel<IToDoItem>
    {
        /// <summary>
        /// An even object that alerts the ToDoMainViewModel that a new IToDoItem is added.
        /// </summary>
        public event EventHandler<IToDoItem> SubmitToDoItemEvent;




        public SubmitToDoViewModel()
        {

            /// When the submit button is clicked the SubmitToDoItemEvent is fired
            /// and tells the ToDoMainViewModel that a new IToDoItem has been created.
            Submit = new RelayCommand(o =>
            {
                SubmitToDoItemEvent?.Invoke(this, Model);
            });
        }



        /// <summary>
        /// The command that is applied to the Submit button on the SubmitToDoView
        /// </summary>
        public ICommand Submit { get; set; }
    }
}
