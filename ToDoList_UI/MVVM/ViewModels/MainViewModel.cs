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
        /// <summary>
        /// Responsible for most operations concerning the Categorys and related data
        /// </summary>
        public ToDoOperationManager Manager 
        {
            get { return _manager; }
            set
            {
                _manager = value;
                OnPropertyChanged("Manager");
            } 
        }


        /// <summary>
        /// Recieves the ToDoOperationManager responsible for most operations.
        /// </summary>
        /// <param name="manager"></param>
        public MainViewModel(ToDoOperationManager manager)
        {
            _manager = manager;
            RunTask();
        }
        public async void RunTask()
        {
            try
            {
                await Manager.GetCategories();
                OnPropertyChanged("Manager");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
