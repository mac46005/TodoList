using DataAccess_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ClassLib.Interfaces
{
    public interface IToDoItem : IToDo, IDueDate,IPastDue,IModel<int>
    {
    }
}
