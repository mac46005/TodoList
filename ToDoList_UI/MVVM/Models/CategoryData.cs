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

        /// <summary>
        /// Constructors recieves the Selected Category Data
        /// </summary>
        /// <param name="categoryData">Recieves the SelectedCategory's Data from ToDoOperationManager</param>
        public CategoryData(ICategoryData categoryData)
        {
            _categoryData = categoryData;
            PopulateViewModelsList();
        }







        /// <summary>
        /// Populates the ObservableCollections ToDoItemViewModelList and CompletedItemViewModelList with the ICategory Data
        /// </summary>
        public void PopulateViewModelsList()
        {
            _categoryData.ToDoItems
                .ForEach(item => ToDoITemViewModelList.Add(new ToDoItemViewModel(item)));

            _categoryData.CompletedItems
                .ForEach(item => CompletedItemViewModelList.Add(new CompletedItemViewModel(item)))
        }
        


        /// <summary>
        /// Empties ObservableCollection Lists
        /// </summary>
        private void EmptyLists()
        {
            ToDoITemViewModelList.Clear();
            CompletedItemViewModelList.Clear();
        }

    }
}
