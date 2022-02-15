
using DataAccess_ClassLib.Interfaces;
using ToDo_ClassLib.Models;

namespace ToDo_ClassLib.Interfaces
{
    public interface ICategory : IModel<int>, ICategoryData
    {
        string Name { get; set; }
    }
}