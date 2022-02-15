using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ClassLib.Interfaces
{
    public interface ICategoryData
    {
        List<IToDoItem> ToDoItems { get; set; }
        List<ICompletedItem> CompletedItems { get; set; }
    }
}
