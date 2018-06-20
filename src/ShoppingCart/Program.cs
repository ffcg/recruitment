// me@henriklarsson.eu
// Bra? Dåligt? You tell me! =[
// En annan är fortfarande halv-ny, 2 år i branchen.

using System;

namespace TerriBad.ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            IShoppingCart shoppingCart = ShopFactory.CreateShoppingCart();

            for (int i = 1; i <= 11; i++)
            {
                ICartItem item = ShopFactory.CreateItem();
                item.ProductId = i;
                item.Cost = ((i * i + 3.7m) * 2.1m / 4.2m); // just some random numbers
                shoppingCart.Add(item);
            }

            Print($"Total: {shoppingCart.Sum():C2}");
            Print($"Discount: " +
                $"{shoppingCart.GetDiscountPercentage(ShopFactory.CreateDiscount().CalculateLeveledDiscout):P}");
            Print($"Subtotal: " +
                $"{shoppingCart.Sum() * (1 - shoppingCart.GetDiscountPercentage(ShopFactory.CreateDiscount().CalculateLeveledDiscout)):C2}");
            Console.ReadKey();
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
