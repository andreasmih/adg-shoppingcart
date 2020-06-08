using System.Collections.Generic;
using NUnit.Framework;
using ShoppingCart;
using ShoppingCart.Models;

namespace ShoppingCartTest
{
    public class TestBase
    {
        protected CartService shoppingCartService;
        protected ItemService itemService;
        protected Dictionary<string, Item> items;
        protected Dictionary<int, Cart> carts;

        [SetUp]
        public void Setup()
        {
            //service setup
            itemService = new ItemService();
            shoppingCartService = new CartService(itemService);

            // data setup
            carts = new Dictionary<int, Cart>();
            items = new Dictionary<string, Item>();

            SeedItems();
            SeedCarts();
        }

        private void SeedCarts()
        {
            carts.Add(1, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 1},
                    new CartItem{ Item = items["A"] , Times = 1},
                    new CartItem{ Item = items["A"] , Times = 1},
                    new CartItem{ Item = items["B"] , Times = 1},
                    new CartItem{ Item = items["A"] , Times = 1},
                }
            });
            carts.Add(2, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 3},
                    new CartItem{ Item = items["B"] , Times = 3},
                    new CartItem{ Item = items["A"] , Times = 3},
                    new CartItem{ Item = items["A"] , Times = 4},
                    new CartItem{ Item = items["B"] , Times = 4},
                }
            });
            carts.Add(3, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 1},
                    new CartItem{ Item = items["B"] , Times = 1},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                }
            });
        }

        private void SeedItems()
        {
            var item = new Item
            {
                ItemName = "A",
                BasePrice = 5m,
                Offers = new List<Offer>
                {
                    new Offer{ IsValid = true, Count = 3, TotalPrice = 13.00m},
                    new Offer{ IsValid = true, Count = 5, TotalPrice = 20.00m}
                }
            };
            items.Add(item.ItemName, item);
            item = new Item
            {
                ItemName = "B",
                BasePrice = 3m,
                Offers = new List<Offer>
                {
                    new Offer{ IsValid = true, Count = 4, TotalPrice = 9m},
                    new Offer{ IsValid = false, Count = 5, TotalPrice = 10.00m}
                }
            };
            items.Add(item.ItemName, item);
            item = new Item
            {
                ItemName = "C",
                BasePrice = 2m,
            };
            items.Add(item.ItemName, item);
            item = new Item
            {
                ItemName = "D",
                BasePrice = 1.5m,
            };
            items.Add(item.ItemName, item);
        }
    }
}
