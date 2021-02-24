namespace CoffeeShopNoDecorator
{
    public class DarkRoastWithSoy :  Beverage
    {
        public DarkRoastWithSoy()
        {
            Description = "Dark roast with soy milk";            
        }

        public override decimal GetPrice()
        {
            return 1.1m;
        }
    }
}