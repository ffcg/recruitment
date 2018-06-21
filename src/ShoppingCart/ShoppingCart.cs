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

        public decimal GetDiscountPercentage(Discount discount = null) //Flera olika modeller av rabatter möjliga
        {
            /*
                Har inte så bra koll på programmeringssyntax längre (se ovan parameter som säkert är fel)
                Ber också om ursäkt för tankevurpor och metoder som inte finns :)
            */
           
            /* Standardvärden först och lite felkoll */
            int interval = 5;
            int maxDiscount = 50 // = 50 vi vill ju inte ge 120% rabatt (se senare) om kunden köper väldigt många varor.
            int firstDiscountStep = 10
            if(discount != null) {
                int interval = discount.getInterval(); //Från databasmodellen
                int maxDiscount = discount.getMaxDiscount(); 
                int firstDiscountStep = discount.getFirstDiscountStep();
            }
            
            /* Tänkte mig följande scenario med en if-sats */
        
            int step = floor(_items.Count/interval)*interval;
            int amount = step + sign(step)*(firstDiscountStep-interval);
            return amount > maxDiscount ? maxDiscount : amount;

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
