using System.Collections.Generic;

namespace Bad.ShoppingCart
{
    public class ShoppingCart
    {
        private readonly IList<CartItem> _items;

        public ShoppingCart()
        {
            _items = new List<CartItem>();
        }

        public decimal GetDiscountPercentage()
        {
            int nofItems = _items.Count;

            if (nofItems < 5 || nofItems > 14)
            {
                return 0m;
            }

            decimal discount = 10m;

            if (nofItems > 9)
            {
                discount += 5m;
            }

            return discount;
        }

        public void Add(CartItem cartItem)
        {
            _items.Add(cartItem);
        }

        public void Remove(CartItem cartItem)
        {
            _items.Remove(cartItem);
        }
    }
}