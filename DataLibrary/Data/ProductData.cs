using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class ProductData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public ProductData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public Task<List<ProductModel>> GetProducts()
        {
            return _dataAccess.LoadData<ProductModel, dynamic>("dbo.spProducts_All",
                                                                new { },
                                                                _connectionString.SqlConnectionName);
        }
    }
}
