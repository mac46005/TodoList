using DataAccess_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.Models
{
    public class ToDoItem : IModel<int>,IToDoItem
    {
        public int ID { get; set; }
        public string ToDo { get; set; } = String.Empty;
        public DateTime DueDate { get; set; }
        public bool IsPastDue 
        { 
            get
            {
                if(DueDate > DateTime.Now)
                {
                    PastDueEvent?.Invoke(this, new EventArgs());
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsComplete { get; set; } = false;


        public int Category_ID { get; set; }



        public event EventHandler PastDueEvent;
    }
}
