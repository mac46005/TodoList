using DataAccess_ClassLib.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.DataAccess;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.Models
{
    /// <summary>
    /// Manages the Todo Logic
    /// </summary>
    public class ToDoOperationManager
    {
        /// <summary>
        /// Tells the subcriber that the category has changed
        /// </summary>
        public event EventHandler ChangeCategoryEvent;




        /// DATA ACCESS ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        IDataAccessAsync<ICategory, int> _categoryDataAccess;
        ICategoryItemDataAccess<IToDoItem, int> _toDoItemDataAccess;
        ICategoryItemDataAccess<ICompletedItem, int> _completedItemDataAccess;
        /// END DATA ACCESS /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        public ToDoOperationManager(
            IDataAccessAsync<ICategory,int> categoryDataAccess,
            ICategoryItemDataAccess<IToDoItem,int> todoItemDataAccess,
            ICategoryItemDataAccess<ICompletedItem,int> completeItemDataAccess)
        {
            _categoryDataAccess = categoryDataAccess;
            _toDoItemDataAccess = todoItemDataAccess;
            _completedItemDataAccess = completeItemDataAccess;
        }


        /// <summary>
        /// List of Categories objects
        /// </summary>
        ObservableCollection<ICategory> Categories { get; set; }




        private ICategory _selectCategory;
        /// <summary>
        /// Currently Selected Category
        /// </summary>
        public ICategory SelectedCategory 
        {
            get { return _selectCategory; }
            set 
            { 
                _selectCategory = value; 
                ChangeCategoryEvent?.Invoke(this, EventArgs.Empty);
            } 
        }






        /// <summary>
        /// Gets the currently selected Category Data
        /// </summary>
        /// <returns></returns>
        public async Task<ICategoryData> GetCategoryData()
        {
            ICategoryData selectedCategoryData = SelectedCategory;
            if (SelectedCategory == null)
            {
                return null;
            }
            else
            {
                selectedCategoryData.ToDoItems = new List<IToDoItem>(await _toDoItemDataAccess.GetByCategoryID(SelectedCategory.ID));
                selectedCategoryData.CompletedItems = new List<ICompletedItem>(await _completedItemDataAccess.GetByCategoryID(SelectedCategory.ID));
                return selectedCategoryData;
            }
        }
        
    }
}
