using DataAccess_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;
using ToDo_ClassLib.Models;
using ToDoList_UI.Core;

namespace ToDoList_UI.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel<ObservableCollection<IViewModel<IModel<int>>>>
    {
        private ToDoOperationManager _manager;
        public ToDoOperationManager Manager 
        {
            get { return _manager; }
            set
            {
                _manager = value;
                OnPropertyChanged("Manager");
            } 
        }



        public MainViewModel(ToDoOperationManager manager)
        {
            _manager = manager;
        }




    }
}
