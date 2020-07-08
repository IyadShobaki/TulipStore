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

        public List<ProductModel> Products { get; set; }
        public DisplayModel(IProductData productData)
        {
            _productData = productData;
        }
        public async Task OnGet()
        {
            Products = await _productData.GetProducts();
        }
    }
}