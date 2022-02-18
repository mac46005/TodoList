using DataAccess_ClassLib.DataAccess;
using DataAccess_ClassLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_ClassLib.DataAccess
{
    public interface ICategoryItemDataAccess<T,U> : IDataAccessAsync<T,U> where T : IModel<U>
    {
        Task<IEnumerable<T>> GetByCategoryID(U categoryID);
    }
}
