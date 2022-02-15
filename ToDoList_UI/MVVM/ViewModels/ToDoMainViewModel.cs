using DataAccess_ClassLib.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;
using ToDo_ClassLib.Models;
using ToDoList_UI.MVVM.Models;

namespace ToDoList_UI.MVVM.ViewModels
{
    /// <summary>
    /// The ToDo MainView model.
    /// Contains the representaton of all logic necessary to add edit delete CompletedItems and ToDoItems.
    /// Takes the Singleton ToDoOperationManager to load the CurrentlySelectedCategory
    /// </summary>
    public class ToDoMainViewModel : BaseViewModel<CategoryData>
    {
        ToDoOperationManager _manager;



        public ToDoMainViewModel(ToDoOperationManager manager)
        {
            _manager = manager;

            _manager.ChangeCategoryEvent += _manager_ChangeCategoryEvent;
        }


        /// <summary>
        /// Creates a new CategoryData Object and Populates is with data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void _manager_ChangeCategoryEvent(object? sender, EventArgs e)
        {
            Model = new CategoryData( await _manager.GetCategoryData());
        }





        public async void LoadData()
        {

        }
    }
}
