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
    public class ToDoItemsDataAccess : ICategoryItemDataAccess<IToDoItem,int>
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
                await connection.ManipulateData<IToDoItem>("ToDo_DB", SPNameHelper.StoredProcedureName("AddToDoItem"), model);
                return model;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (var connection = _sqlDataAccess)
            {
                await connection.LoadSingleData<IToDoItem, dynamic>("ToDo_DB", SPNameHelper.StoredProcedureName("DeleteToDoItem"), new { ID = id });
                return true;
            }
        }

        public async Task<IEnumerable<IToDoItem>> GetAllAsync()
        {
            using(var connection = _sqlDataAccess)
            {
                return await connection.LoadMany<IToDoItem>("ToDo_DB", SPNameHelper.StoredProcedureName("GetAll"));
            }
        }

        public async Task<IToDoItem> GetAsync(int id)
        {
            using (var connection = _sqlDataAccess)
            {
                return await connection.LoadSingleData<IToDoItem,dynamic>("ToDo_DB",SPNameHelper.StoredProcedureName("GetToDoItem"),new { ID = id });
            }
        }

        public Task<IToDoItem> UpdateAsync(int id, IToDoItem entity)
        {
            using (var connection = _sqlDataAccess)
            {
                entity.ID = id;
                connection.ManipulateData<IToDoItem>("ToDo_DB", SPNameHelper.StoredProcedureName("UpdateToDoItem"), entity);
                return (Task<IToDoItem>)entity;
            }
        }









        // Custom Defined Methods
        /// <summary>
        /// Get ToDoItem by Category ID
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public Task<IEnumerable<IToDoItem>> GetByCategoryID(int categoryID)
        {
            using(var connection = _sqlDataAccess)
            {
                return connection.LoadMany<IToDoItem, dynamic>("ToDo_DB", SPNameHelper.StoredProcedureName("GetByCategoryID"), new { CategoryID = categoryID });
            }
        }
    }
}
