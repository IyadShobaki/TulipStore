﻿using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface IOrderData
    {
        Task<int> CreateOrder(OrderModel order);
        Task<List<OrderModel>> GetOrders();
        Task<List<OrderModel>> GetOrderMaxId();
        Task UpdateRecord(int orderId, int numberOfItems, decimal orderPrice);

        Task<int> DeleteOrder(int orderId);
    }
}