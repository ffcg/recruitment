namespace TerriBad.ShoppingCart
{
    public interface ICartItem
    {
        int ProductId { get; set; }
        decimal Cost { get; set; }
    }
}