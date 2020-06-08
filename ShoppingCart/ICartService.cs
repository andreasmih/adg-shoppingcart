using ShoppingCart.Models;

namespace ShoppingCart
{
    public interface ICartService
    {
        decimal CalculateCartPrice(Cart cart);
    }
}
