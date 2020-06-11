using System.Collections.Generic;
using NUnit.Framework;
using ShoppingCart;
using ShoppingCart.Models;

namespace ShoppingCartTest
{
    public class TestBase
    {
        protected CartService shoppingCartService;
        protected MultipleOfferCartService multipleOfferShoppingCartService;
        protected ItemService itemService;
        protected Dictionary<string, Item> items;
        protected Dictionary<int, Cart> carts;

        [SetUp]
        public void Setup()
        {
            //service setup
            itemService = new ItemService();
            shoppingCartService = new CartService(itemService);
            multipleOfferShoppingCartService = new MultipleOfferCartService(itemService);

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
            carts.Add(4, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 2},
                    new CartItem{ Item = items["B"] , Times = 1},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                },
                Offers = new List<MultipleOffer>
                {
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 2},
                            new CartItem { Item = items["B"], Times = 1},
                        },
                        Price = 10.5m
                    }
                }
            });
            carts.Add(5, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 2},
                    new CartItem{ Item = items["B"] , Times = 1},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                },
                Offers = new List<MultipleOffer>
                {
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 2},
                        },
                        Price = 7m
                    }
                }
            });
            carts.Add(6, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 5},
                    new CartItem{ Item = items["B"] , Times = 1},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                },
                Offers = new List<MultipleOffer>
                {
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 2},
                            new CartItem { Item = items["B"], Times = 1}
                        },
                        Price = 10.5m
                    }
                }
            });
            carts.Add(7, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 5},
                    new CartItem{ Item = items["B"] , Times = 2},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                },
                Offers = new List<MultipleOffer>
                {
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 3},
                            new CartItem { Item = items["B"], Times = 1}
                        },
                        Price = 11m
                    },
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 5},
                            new CartItem { Item = items["B"], Times = 2}
                        },
                        Price = 23m
                    }
                }
            });
            carts.Add(8, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 5},
                    new CartItem{ Item = items["B"] , Times = 2},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                },
                Offers = new List<MultipleOffer>
                {
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 3},
                            new CartItem { Item = items["B"], Times = 1}
                        },
                        Price = 14m
                    },
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 5},
                        },
                        Price = 20m
                    }
                }
            });
            carts.Add(9, new Cart
            {
                CartItems = new List<CartItem>
                {
                    new CartItem{ Item = items["A"] , Times = 5},
                    new CartItem{ Item = items["B"] , Times = 2},
                    new CartItem{ Item = items["C"] , Times = 1},
                    new CartItem{ Item = items["D"] , Times = 1},
                },
                Offers = new List<MultipleOffer>
                {
                    new MultipleOffer
                    {
                        IsValid = true,
                        Items = new List<CartItem>
                        {
                            new CartItem { Item = items["A"], Times = 3},
                            new CartItem { Item = items["B"], Times = 1}
                        },
                        Price = 14m
                    },
                }
            });
        }

        private void SeedItems()
        {
            var item = new Item
            {
                ItemName = "A",
                BasePrice = 5m,
                Offers = new List<SingleOffer>
                {
                    new SingleOffer{ IsValid = true, Count = 3, TotalPrice = 13.00m},
                    new SingleOffer{ IsValid = true, Count = 5, TotalPrice = 20.00m}
                }
            };
            items.Add(item.ItemName, item);
            item = new Item
            {
                ItemName = "B",
                BasePrice = 3m,
                Offers = new List<SingleOffer>
                {
                    new SingleOffer{ IsValid = true, Count = 4, TotalPrice = 9m},
                    new SingleOffer{ IsValid = false, Count = 5, TotalPrice = 10.00m}
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
