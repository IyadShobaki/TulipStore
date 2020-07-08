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
    public class OrderData : IOrderData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public OrderData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }
        public async Task<int> CreateOrder(OrderModel order)
        {
            DynamicParameters p = new DynamicParameters();

            p.Add("OrderName", order.OrderName);
            p.Add("OrderDate", order.OrderDate);
            p.Add("NumberOfItems", order.NumberOfItems);
            p.Add("OrderPrice", order.OrderPrice);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("spOrder_Insert", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");

        }
        public Task<List<OrderModel>> GetOrders()
        {
            return _dataAccess.LoadData<OrderModel, dynamic>("dbo.spOrders_All",
                                                                new { },
                                                                _connectionString.SqlConnectionName);
        }

        public Task<List<OrderModel>> GetOrderMaxId()
        {
            return _dataAccess.LoadData<OrderModel, dynamic>("dbo.spOrder_GetMaxID",
                                                                new { },
                                                                _connectionString.SqlConnectionName);
        }
    }
}
