namespace CoffeeShopNoDecorator
{
    public class DarkRoast :  Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roast";            
        }

        public override decimal GetPrice()
        {
            return 1.1m;
        }
    }
}