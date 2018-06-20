namespace TerriBad.ShoppingCart
{
    public static class ShopFactory
    {        
        public static IShoppingCart CreateShoppingCart()
        {
            return new ShoppingCart();
        }

        public static ICartItem CreateItem()
        {
            return new CartItem();
        }

        public static IDiscount CreateDiscount()
        {
            return new Discount();
        }
    }
}
