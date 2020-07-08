using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class CartModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "You can select up to 10 piece")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
