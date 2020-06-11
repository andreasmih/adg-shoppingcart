using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ShoppingCartTest
{
    public class MultipleOfferCartServiceTest : TestBase
    {
        [Test]
        public void CalculateCartPriceMultipleOfferAppliedTest()
        {
            var usedCart = carts[4];
             Assert.AreEqual(14m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceSingleOffersMultipleAppliedTest()
        {
            var usedCart = carts[5];
            Assert.AreEqual(13.5m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceNotValidMultipleOfferTest()
        {
            var usedCart = carts[5];
            usedCart.Offers[0].IsValid = false;
            Assert.AreEqual(16.5m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceBothOffersAppliedTest() 
        {
            var usedCart = carts[6];
            Assert.AreEqual(27m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceUseBestOfferTest()
        {
            var usedCart = carts[7];
            Assert.AreEqual(26.5m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceUseBestAndMultipleAsSingleOfferTest()
        {
            var usedCart = carts[8];
            Assert.AreEqual(29.5m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }

        [Test]
        public void CalculateCartPriceSingleOfferAppliedLastTest()
        {
            var usedCart = carts[9];
            Assert.AreEqual(30.5m, multipleOfferShoppingCartService.CalculateCartPrice(usedCart));
        }
    }
}
