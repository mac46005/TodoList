
using DataAccess_ClassLib.Interfaces;
using ToDo_ClassLib.Models;

namespace ToDo_ClassLib.Interfaces
{
    public interface ICategory : IModel<int>
    {
        string Name { get; set; }
        List<ToDoItem>? ToDoItems { get; set; }
        List<CompletedItem> CompletedItems { get; set; }
    }
}