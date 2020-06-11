using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Models;

namespace ShoppingCart
{
    public class ItemService : IItemService
    {
        public decimal CalculateItemPrice(Item item, int times)
        {
            if (item == null || times == 0)
                return 0m;

            decimal total = 0;
            if (item.Offers != null)
            {
                foreach (var offer in item.Offers.Where(o => o.IsValid && o.Type == Constants.OfferTypes.SingleOffer).OrderByDescending(o => o.Count))
                {
                    while (offer.Count <= times)
                    {
                        total += offer.TotalPrice;
                        times -= offer.Count;
                    }
                }
            }

            if (times > 0)
            {
                total += item.BasePrice * times;
            }

            return total;
        }
    }
}
