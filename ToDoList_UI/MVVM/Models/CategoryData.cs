using DataAccess_ClassLib.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.DataAccess;
using ToDo_ClassLib.Interfaces;
using ToDoList_UI.MVVM.ViewModels;

namespace ToDoList_UI.MVVM.Models
{
    public class CategoryData
    {
        ICategoryData _categoryData;
        public ObservableCollection<ToDoItemViewModel> ToDoITemViewModelList { get; set; }
        public ObservableCollection<CompletedItemViewModel> CompletedItemViewModelList { get; set; }
        public CategoryData(ICategoryData categoryData)
        {
            _categoryData = categoryData;
        }



        public void PopulateViewModelsList()
        {
            
        }

        private void EmptyLists()
        {
            ToDoITemViewModelList.Clear();
            CompletedItemViewModelList.Clear();
        }

    }
}
