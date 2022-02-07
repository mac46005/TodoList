using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ClassLib.Models
{
    public class ToDoItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool PastDue { get; set; }

    }
}
