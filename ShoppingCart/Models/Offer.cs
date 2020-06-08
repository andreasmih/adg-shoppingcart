namespace ShoppingCart.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public bool IsValid { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
