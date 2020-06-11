using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Models
{
    public class SingleOffer : Offer
    {
        public SingleOffer() : base("Single") { }

        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
