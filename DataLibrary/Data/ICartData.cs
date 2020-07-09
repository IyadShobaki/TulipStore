using DataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface ICartData
    {
        Task<int> AddToCart(CartModel cart);
        Task<List<CartModel>> GetCartItems(int orderId);
    }
}