namespace TerriBad.ShoppingCart
{
    public class CartItem : ICartItem
    {   
        public int ProductId { get; set; }
        public decimal Cost { get; set; }
    }
}
