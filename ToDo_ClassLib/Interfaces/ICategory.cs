
using DataAccess_ClassLib.Interfaces;
using ToDo_ClassLib.Models;

namespace ToDo_ClassLib.Interfaces
{
    public interface ICategory : IModel<int>
    {
        List<CompletedItem>? CompletedItems { get; set; }
        string Name { get; set; }
        List<ToDoItem>? ToDoItems { get; set; }
    }
}