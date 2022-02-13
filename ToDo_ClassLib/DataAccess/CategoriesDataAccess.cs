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
    public class CategoriesDataAccess : IDataAccessAsync<ICategory, int>
    {
        ISqlDataAccess<IConfiguration> _sqlDataAccess;
        SPNameHelper SPNameHelper = new SPNameHelper("Categories");

        public CategoriesDataAccess(ISqlDataAccess<IConfiguration> sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }

        public async Task<ICategory> CreateAsync(ICategory model)
        {
            using (var connection = _sqlDataAccess)
            {
                await connection.ManipulateData<ICategory>("ToDo_DB", SPNameHelper.StoredProcedureName("AddCategory"), model);
                return model;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using(var connection = _sqlDataAccess)
            {
                await connection.LoadData<ICategory, dynamic>("ToDo_DB", SPNameHelper.StoredProcedureName("DeleteCategory"), new { ID = id });
                return true;
            }
        }

        public async Task<IEnumerable<ICategory>> GetAllAsync()
        {
            using(var connection = _sqlDataAccess)
            {
                return await connection.LoadData<ICategory>("ToDo_DB",SPNameHelper.StoredProcedureName("GetAll"));
            }
        }

        public async Task<ICategory> GetAsync(int id)
        {
            using( var connection = _sqlDataAccess)
            {
                return await connection.LoadData<ICategory,dynamic>("ToDo_DB",SPNameHelper.StoredProcedureName("GetCategory"),new { ID = id });
            }
        }

        public async Task<ICategory> UpdateAsync(int id, ICategory entity)
        {
            using(var connection = _sqlDataAccess)
            {
                entity.ID = id;
                await connection.ManipulateData("ToDo_DB",SPNameHelper.StoredProcedureName("UpdateCategory"),entity);
            }
        }
    }
}
