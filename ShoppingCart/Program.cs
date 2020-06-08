using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using ShoppingCart.Models;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICartService, CartService>()
                .AddSingleton<IItemService, ItemService>()
                .BuildServiceProvider();

            var cartService = serviceProvider.GetService<ICartService>();
            var value = cartService.CalculateCartPrice(
                new Cart {
                    CartItems = new List<CartItem>
                    {
                        new CartItem
                        {
                            Item = new Item{
                                BasePrice = 4m,
                                ItemName = "A"
                            },
                            Times = 3
                        }
                        
                     }
                });

            if (value > 0)
                Console.WriteLine("DI works. Run the tests to check service correctness.");
        }
    }
}
