using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class MultipleOffer : Offer
    {
        public MultipleOffer(string type) : base(type)
        { }

        public List<CartItem> Items { get; set; }
        public decimal Price { get; set; }
    }
}
