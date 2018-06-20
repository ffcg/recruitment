using System.Collections.Generic;

namespace TerriBad.ShoppingCart
{
    public interface IDiscount
    {
        decimal CalculateLeveledDiscout(IList<ICartItem> items);
    }
}