using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ClassLib.Interfaces
{

    public interface IPastDue
    {
        event EventHandler PastDueEvent;

        bool IsPastDue { get; }
    }
}
