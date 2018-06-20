using System;
using System.Collections.Generic;

namespace TerriBad.ShoppingCart
{
    public interface IShoppingCart
    {
        void Add(ICartItem cartItem);
        void Remove(ICartItem cartItem);
        decimal Sum();
        decimal GetDiscountPercentage(Func<IList<ICartItem>, decimal> calculateDiscout);         
    }
}