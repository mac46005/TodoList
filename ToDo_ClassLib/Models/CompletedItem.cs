using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.Models
{
    public class CompletedItem : ICompletedItem
    {
        public int ID { get; set; }
        public int ToDoItem_ID { get; set; }

        public ToDoItem? ToDoItem { get; set; }

        public DateTime DateTimeCompleted { get; set; }

        public int Category_ID { get; set; }
    }
}
