using System;
using System.Collections.Generic;
using System.Linq;

namespace TerriBad.ShoppingCart
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly IList<ICartItem> _items;

        public ShoppingCart()
        {
            _items = new List<ICartItem>();
        }

        public decimal GetDiscountPercentage(Func<IList<ICartItem>, decimal> calculateDiscout)
        {            
            return calculateDiscout(_items);
        }

        public void Add(ICartItem cartItem)
        {
            _items.Add(cartItem);
        }

        public void Remove(ICartItem cartItem)
        {
            _items.Remove(cartItem);
        }

        public decimal Sum()
        {
            return _items.Sum(c => c.Cost);
        }
    }
}