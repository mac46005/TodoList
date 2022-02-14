using DataAccess_ClassLib.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.Models
{
    public class ToDoOperationManager
    {
        public event EventHandler ChangeCategoryEvent;

        IDataAccessAsync<ICategory, int> _categoryDataAccess;


        public ToDoOperationManager(IDataAccessAsync<ICategory,int> categoryDataAccess)
        {
            _categoryDataAccess = categoryDataAccess;
            
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
        
    }
}
