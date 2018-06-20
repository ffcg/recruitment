using System.Collections.Generic;

namespace TerriBad.ShoppingCart
{
    public class Discount : IDiscount
    {
        public decimal CalculateLeveledDiscout(IList<ICartItem> items)
        {
            if (items.Count >= 5 && items.Count < 10) return .10m;
            else if (items.Count >= 10 && items.Count < 15) return .15m;
            else return 0m;
        }
    }
}
