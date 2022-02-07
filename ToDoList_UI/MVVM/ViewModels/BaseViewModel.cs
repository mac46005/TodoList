using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_UI.Core;

namespace ToDoList_UI.MVVM.ViewModels
{
    public abstract class BaseViewModel<T> : ObservableObject, IViewModel<T>
    {
        public T Model { get; set; }
    }
}
