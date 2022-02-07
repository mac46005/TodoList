using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ClassLib.Interfaces
{
    internal interface IToDoItem : IToDo, IDueDate,IPastDue
    {
    }
}
