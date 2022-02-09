using DataAccess_ClassLib.Interfaces;
using ToDo_ClassLib.Models;

namespace ToDo_ClassLib.Interfaces
{
    public interface ICompletedItem : IModel<int>
    {
        int Category_ID { get; set; }
        DateTime DateTimeCompleted { get; set; }
        int ID { get; set; }
        ToDoItem? ToDoItem { get; set; }
        int ToDoItem_ID { get; set; }
    }
}