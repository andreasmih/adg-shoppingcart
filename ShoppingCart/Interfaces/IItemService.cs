using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Models;

namespace ShoppingCart
{
    public interface IItemService
    {
        decimal CalculateItemPrice(Item item, int times);
    }
}
