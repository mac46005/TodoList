using DataAccess_ClassLib.DataAccess;
using DataAccess_ClassLib.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo_ClassLib.Interfaces;

namespace ToDo_ClassLib.DataAccess
{
    public class ToDoItemsDataAccess : IDataAccessAsync<IToDoItem, int>
    {
        ISqlDataAccess<IConfiguration> _sqlDataAccess;
        SPNameHelper SPNameHelper = new SPNameHelper("ToDoItems");
        public ToDoItemsDataAccess(ISqlDataAccess<IConfiguration> sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }
        public async Task<IToDoItem> CreateAsync(IToDoItem model)
        {
            using (var connection = _sqlDataAccess)
            {
                await connection.ManipulateData<IToDoItem>("", SPNameHelper.StoredProcedureName("Add"), model);
                return model;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (var connection = _sqlDataAccess)
            {
                await connection.LoadData<IToDoItem, dynamic>("", "", new { ID = id });
                return true;
            }
        }

        public async Task<IEnumerable<IToDoItem>> GetAllAsync()
        {
            using(var connection = _sqlDataAccess)
            {
                return await connection.LoadData<IToDoItem>("", "");
            }
        }

        public async Task<IToDoItem> GetAsync(int id)
        {
            using (var connection = _sqlDataAccess)
            {
                return await connection.LoadData<IToDoItem,dynamic>("","",new { ID = id });
            }
        }

        public Task<IToDoItem> UpdateAsync(int id, IToDoItem entity)
        {
            using (var connection = _sqlDataAccess)
            {
                entity.ID = id;
                connection.ManipulateData<IToDoItem>("", "", entity);
                return entity;
            }
        }
    }
}
