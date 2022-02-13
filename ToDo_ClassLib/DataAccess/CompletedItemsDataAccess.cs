﻿using DataAccess_ClassLib.DataAccess;
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
    internal class CompletedItemsDataAccess : IDataAccessAsync<ICompletedItem, int>
    {


        ISqlDataAccess<IConfiguration> _sqlDataAccess;
        SPNameHelper SPNameHelper = new SPNameHelper("CompletedItems");


        public CompletedItemsDataAccess(ISqlDataAccess<IConfiguration> sqlDataAccess)
        {
            _sqlDataAccess = sqlDataAccess;
        }



        public async Task<ICompletedItem> CreateAsync(ICompletedItem model)
        {
            using(var connection = _sqlDataAccess)
            {
                await connection.ManipulateData<ICompletedItem>("ToDo_DB", SPNameHelper.StoredProcedureName("AddCompletedItem"), model);
                return model;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (var connection = _sqlDataAccess)
            {
                await connection.ManipulateData<dynamic>("ToDo_DB", SPNameHelper.StoredProcedureName("DeleteCompletedItem"), new { ID = id });
                return true;
            }
        }

        public async Task<IEnumerable<ICompletedItem>> GetAllAsync()
        {
            using (var connection = _sqlDataAccess)
            {
                return await connection.LoadData<ICompletedItem>("ToDo_DB", SPNameHelper.StoredProcedureName("GetAll"));
            }
        }

        public async Task<ICompletedItem> GetAsync(int id)
        {
            using( var connection = _sqlDataAccess)
            {
                return await connection.LoadData<ICompletedItem,dynamic>("ToDo_DB", SPNameHelper.StoredProcedureName("GetCompletedItem"), new {ID = id}));
            }
        }

        public async Task<ICompletedItem> UpdateAsync(int id, ICompletedItem entity)
        {
            using(var connection = _sqlDataAccess)
            {
                entity.ID = id;
                await connection.ManipulateData("ToDo_DB", SPNameHelper.StoredProcedureName("UpdateCompletedItem"),entity);
                return entity;
            }
        }
    }
}
