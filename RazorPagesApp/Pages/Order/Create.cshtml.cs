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
    public class CreateModel : PageModel
    {
        private readonly IOrderData _orderData;
        [BindProperty]
        public OrderModel Order { get; set; }
        public CreateModel(IOrderData orderData)
        {
            _orderData = orderData;
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            Order.NumberOfItems = 0;
            Order.OrderPrice = 0.0M;
            int id = await _orderData.CreateOrder(Order);

            return RedirectToPage("/Products/Display", new { Id = id });

        }
    }
}