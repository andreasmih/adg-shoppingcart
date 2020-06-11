using System.Globalization;

namespace ShoppingCart.Models
{
    public abstract class Offer
    {
        protected Offer(string type)
        {
            Type = type;
        }

        public int Id { get; set; }
        public bool IsValid { get; set; }
        public virtual string Type { get; set; }
    }
}
