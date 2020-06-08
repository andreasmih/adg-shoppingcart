using System.Linq;
using ShoppingCart.Models;

namespace ShoppingCart
{
    public class CartService : ICartService
    {
        private readonly IItemService itemService;

        public CartService(IItemService itemService)
        {
            this.itemService = itemService;
        }

        public decimal CalculateCartPrice(Cart cart)
        {
            if (cart?.CartItems == null)
                return 0m;
            
            // grouping by Id is the better idea overall, but grouping by ItemName is what the requirements state
            var groupedCart = cart.CartItems.GroupBy(o => o.Item.ItemName)
                                            .ToDictionary(o => o.FirstOrDefault(), o => o.Sum(t => t.Times));

            var totalValue = 0m;
            foreach (var product in groupedCart)
            {
                totalValue += itemService.CalculateItemPrice(product.Key.Item, product.Value);
            }

            return totalValue;
        }
    }
}
