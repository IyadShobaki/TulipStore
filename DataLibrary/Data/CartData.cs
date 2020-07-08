using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class CartData : ICartData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public CartData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }
        public async Task<int> AddToCart(CartModel cart)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("ProductName", cart.ProductName);
            p.Add("ProductId", cart.ProductId);
            p.Add("Quantity", cart.Quantity);
            p.Add("Total", cart.Total);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("spCart_Insert", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");

        }
    }
}
