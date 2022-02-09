using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Models;

namespace ToDoList_UI.MVVM.ViewModels
{
    public class SubmitToDoViewModel
    {
        public event EventHandler<ToDoItem> SubmitToDoItemEvent;
    }
}
