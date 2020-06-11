using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class MultipleOfferCartService : ICartService
    {
        private readonly IItemService itemService;
        public MultipleOfferCartService(IItemService itemService)
        {
            this.itemService = itemService;
        }

        public decimal CalculateCartPrice(Cart cart)
        {
            if (cart?.CartItems == null)
                return 0m;

            decimal totalPrice = 0m;
            var cartDictionary = cart.CartItems.GroupBy(o => o.Item.ItemName)
                                                .ToDictionary(o => o.FirstOrDefault().Item, o => o.Sum(t => t.Times));
            
            foreach (var offer in cart.Offers.OrderByDescending(o => o.Items.Sum(t => t.Item.BasePrice * t.Times) - o.Price))
            {
                if (offer.Type == Constants.OfferTypes.MultipleOffer && offer.IsValid)
                {
                    if(offer.Items.All(o => o.Times <= cartDictionary[o.Item]))
                    {
                        foreach (var item in offer.Items)
                            cartDictionary[item.Item] -= item.Times;
                        totalPrice += offer.Price;
                    }
                }
            }

            var remainingItems = cartDictionary.Where(o => o.Value > 0).ToList();
            foreach (var item in remainingItems)
                totalPrice += itemService.CalculateItemPrice(item.Key, item.Value);

            return totalPrice;
        }
    }
}
