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
        private T _model;
        public T Model { 
            get 
            {
                return _model;
            } 
            set
            {
                _model = value;
                OnPropertyChanged("Model");
            }
        }





        public BaseViewModel()
        {
        }
    }
}
