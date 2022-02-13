using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.Models
{
    public class ToDoOperationManager
    {
        public List<ICategory> Categories { get; set; }

        public ICategory category { get; set; }

        public ToDoOperationManager()
        {

        }

        public void RefreshCategoryList()
        {

        }
    }
}
