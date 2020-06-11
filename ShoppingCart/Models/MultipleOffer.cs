using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class MultipleOffer : Offer
    {
        public MultipleOffer() : base(Constants.OfferTypes.MultipleOffer)
        { }

        public List<CartItem> Items { get; set; }
        public decimal Price { get; set; }
    }
}
