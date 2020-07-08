using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLibrary.Data;
using DataLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages.Products
{
    public class DisplayModel : PageModel
    {
        private readonly IProductData _productData;
        private readonly ICartData _cartData;
        private readonly IOrderData _orderData;

        public List<ProductModel> Products { get; set; }

        [BindProperty]
        public CartModel Cart { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public DisplayModel(IProductData productData,
            ICartData cartData,
            IOrderData orderData)
        {
            _productData = productData;
            _cartData = cartData;
            _orderData = orderData;

        }
        
        public async Task OnGet()
        {
            Products = await _productData.GetProducts();
           
        }
    
        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
           

            var prodcut = await _productData.GetProducts();

            Cart.Total = Cart.Quantity * prodcut.Where(x => x.Id == Cart.ProductId).First().ProductPrice;

            Cart.OrderId = Id;

            int id = await _cartData.AddToCart(Cart);


           return RedirectToPage("./Display", new { Id = Id});

        }
      
    }
}