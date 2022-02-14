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

        ICategoryItemDataAccess<IToDoItem, int> _todoItemDataAccess;
        ICategoryItemDataAccess<ICompletedItem,int> _completedItemDataAccess;

        public int CategoryId { get; set; }


        public ObservableCollection<ToDoItemViewModel> ToDoITemViewModelList { get; set; }
        public ObservableCollection<CompletedItemViewModel> CompletedItemViewModelList { get; set; }



        private ObservableCollection<IToDoItem> _toDoItems;
        private ObservableCollection<ICompletedItem> _completedItems;


        public CategoryData(
            ICategoryItemDataAccess<IToDoItem,int> todoItemDataAccess,
            ICategoryItemDataAccess<ICompletedItem,int> completeItemDataAccess)
        {
            _todoItemDataAccess = todoItemDataAccess;
            _completedItemDataAccess = completeItemDataAccess;
            
        }


        public async void PrivateData(int CategoryID)
        {
            EmptyLists();

            _toDoItems = new ObservableCollection<IToDoItem>(await _todoItemDataAccess.GetByCategoryID(CategoryID));
            _completedItems = new ObservableCollection<ICompletedItem>(await _completedItemDataAccess.GetByCategoryID(CategoryID));
        }



        public void PopulateViewModelsList()
        {
            
        }

        private void EmptyLists()
        {
            _toDoItems.Clear();
            _completedItems.Clear();
            ToDoITemViewModelList.Clear();
            CompletedItemViewModelList.Clear();
        }

    }
}
