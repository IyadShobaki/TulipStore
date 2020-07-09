using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages.Order
{
    public class DisplayOrderModel : PageModel
    {
        private readonly IOrderData _orderData;
        private readonly ICartData _cartData;

        public DisplayOrderModel(IOrderData orderData, ICartData cartData)
        {
            _orderData = orderData;
            _cartData = cartData;
        }
        public List<OrderModel> Order { get; set; }
        public List<CartModel> CartItems { get; set; }
        public async Task<ActionResult> OnGet()
        {
            Order = await _orderData.GetOrderMaxId();

            CartItems = await _cartData.GetCartItems(Order[0].Id);

            var totalPrice = TotalPrice(CartItems);

            Order[0].NumberOfItems = totalPrice.Item1;
            Order[0].OrderPrice = totalPrice.Item2;
            

            await _orderData.UpdateRecord(Order[0].Id, totalPrice.Item1, totalPrice.Item2);

            return Page();
        }

        private (int, decimal) TotalPrice(List<CartModel> cartItems)
        {
            decimal output = 0.0M;
            int counter = 0;
            foreach (var item in cartItems)
            {
                output += item.Total;
                counter++;
            }

            return (counter, output);
        }
    }
}