using NUnit.Framework;
using ShoppingCart.Models;

namespace ShoppingCartTest
{
    public class CartPriceTest : TestBase
    {
        [Test]
        public void CalculateCartPriceCombineOverlappingItemsTest()
        {
            var usedCart = carts[1];
            Assert.AreEqual(21m, shoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceSimpleTest()
        {
            var usedCart = carts[3];
            Assert.AreEqual(11.5m, shoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartEmptyTest()
        {
            var usedCart = new Cart();
            Assert.AreEqual(0m, shoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartMultipleDoublesTest()
        {
            var usedCart = carts[2];
            Assert.AreEqual(58m, shoppingCartService.CalculateCartPrice(usedCart));
        }
    }
}
