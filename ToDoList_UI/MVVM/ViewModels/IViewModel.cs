using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_UI.MVVM.ViewModels
{
    /// <summary>
    /// The interface that represents a Basic ViewModel.
    /// </summary>
    /// <typeparam name="T">Represents the Model for the ViewModel</typeparam>
    public interface IViewModel<T>
    {
        T Model { get; set; }
    }
}
