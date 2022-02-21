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
using ToDoList_UI.MVVM.Models;

namespace ToDoList_UI.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel<ObservableCollection<IViewModel<CategoryData>>>
    {

        ToDoMainViewModel _toDoMainViewModel;





        private string _currentCategory;
        public string CurrentCategory
        {
            get { return _currentCategory; }
            set
            {
                if (Manager.SelectedCategory != null)
                {
                    _currentCategory = Manager.SelectedCategory.Name;
                    OnPropertyChanged("CurrentCategory");
                }

            }
        }

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
        public MainViewModel(ToDoOperationManager manager,
            ToDoMainViewModel todoMainViewModel)
        {
            _manager = manager;
            _toDoMainViewModel = todoMainViewModel;
            Model = new ObservableCollection<IViewModel<CategoryData>>();
            Model.Add(_toDoMainViewModel);

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
