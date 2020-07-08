using DataLibrary.Models;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public interface ICartData
    {
        Task<int> AddToCart(CartModel cart);
    }
}