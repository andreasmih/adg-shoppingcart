using System.Collections.Generic;

namespace ShoppingCart.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public decimal BasePrice { get; set; }
        public virtual List<SingleOffer> Offers { get; set; }
    }
}
