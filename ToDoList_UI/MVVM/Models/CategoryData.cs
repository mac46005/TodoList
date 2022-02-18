using System.Collections.ObjectModel;
using ToDo_ClassLib.Interfaces;
using ToDoList_UI.MVVM.ViewModels;

namespace ToDoList_UI.MVVM.Models
{
    /// <summary>
    /// Contains the Currently Selected Category Data
    /// </summary>
    public class CategoryData
    {
        ICategoryData _categoryData;
        public ObservableCollection<ToDoItemViewModel> ToDoItemViewModelList { get; set; }
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
            EmptyLists();
            _categoryData.ToDoItems
                .ForEach(item => ToDoItemViewModelList.Add(new ToDoItemViewModel(item)));

            _categoryData.CompletedItems
                .ForEach(item => CompletedItemViewModelList.Add(new CompletedItemViewModel(item)));
        }
        


        /// <summary>
        /// Empties ObservableCollection Lists
        /// </summary>
        private void EmptyLists()
        {
            ToDoItemViewModelList.Clear();
            CompletedItemViewModelList.Clear();
        }

    }
}
