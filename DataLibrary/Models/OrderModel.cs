using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int NumberOfItems { get; set; }
        public decimal OrderPrice { get; set; }
    }
}
