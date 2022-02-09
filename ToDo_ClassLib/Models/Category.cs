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
        public List<ToDoItem>? ToDoItems { get; set; }
        public List<CompletedItem>? CompletedItems { get; set; }
    }
}
