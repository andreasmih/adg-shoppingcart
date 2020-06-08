using NUnit.Framework;
using ShoppingCart.Models;

namespace ShoppingCartTest
{
    public class ItemPriceTest : TestBase
    {
        [Test]
        public void CalculateItemPriceNoMultipleTest()
        {
            var usedItem = items["A"];
            Assert.AreEqual(10m, itemService.CalculateItemPrice(usedItem,2));
        }

        [Test]
        public void CalculateItemPriceOneMultipleTest()
        {
            var usedItem = items["A"];
            Assert.AreEqual(13m, itemService.CalculateItemPrice(usedItem, 3));
        }

        [Test]
        public void CalculateItemPriceMultipleTest()
        {
            var usedItem = items["A"];
            Assert.AreEqual(38m, itemService.CalculateItemPrice(usedItem, 9));
        }

        [Test]
        public void CalculateItemPriceSameOfferx2Test()
        {
            var usedItem = items["B"];
            Assert.AreEqual(9m, itemService.CalculateItemPrice(usedItem, 4));
        }

        [Test]
        public void CalculateItemPriceOfferInvalidTest()
        {
            var usedItem = items["B"];
            Assert.AreEqual(12m, itemService.CalculateItemPrice(usedItem, 5));
        }

        [Test]
        public void CalculateItemPriceNoOfferAvailableTest()
        {
            var usedItem = items["D"];
            Assert.AreEqual(4.5m, itemService.CalculateItemPrice(usedItem, 3));
        }

        [Test]
        public void CalculateItemPriceNoTimesTest()
        {
            var usedItem = items["C"];
            Assert.AreEqual(0m, itemService.CalculateItemPrice(usedItem,0));
        }

        [Test]
        public void CalculateItemPriceNoItemTest()
        {
            Item usedItem = null;
            Assert.AreEqual(0m, itemService.CalculateItemPrice(usedItem, 5));
        }
    }
}