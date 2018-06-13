using System;

namespace Bad.ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());

            Console.WriteLine($"Discount is: {shoppingCart.GetDiscountPercentage()}");
        }
    }
}
