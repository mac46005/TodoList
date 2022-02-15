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
        public event EventHandler ChangeCategoryEvent;

        IDataAccessAsync<ICategory, int> _categoryDataAccess;
        ICategoryItemDataAccess<IToDoItem, int> _toDoItemDataAccess;
        ICategoryItemDataAccess<ICompletedItem, int> _completedItemDataAccess;

        public ToDoOperationManager(
            IDataAccessAsync<ICategory,int> categoryDataAccess,
            ICategoryItemDataAccess<IToDoItem,int> todoItemDataAccess,
            ICategoryItemDataAccess<ICompletedItem,int> completeItemDataAccess)
        {
            _categoryDataAccess = categoryDataAccess;
            _toDoItemDataAccess = todoItemDataAccess;
            _completedItemDataAccess = completeItemDataAccess;





        }



        ObservableCollection<ICategory> Categories { get; set; }
        private ICategory _selectCategory;
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
