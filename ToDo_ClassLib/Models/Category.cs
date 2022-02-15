using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.Models
{
    public class Category : ICategory
    {
        public int ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public List<IToDoItem> ToDoItems { get; set; } = new List<IToDoItem>();
        public List<ICompletedItem> CompletedItems { get; set; } = new List<ICompletedItem>();
    }
}
