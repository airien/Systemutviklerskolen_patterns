namespace CoffeeShopNoDecorator
{
    public class DarkRoastWithMilk : Beverage
    {
        public DarkRoastWithMilk()
        {
            Description = "Dark roast with milk";
        }

        public override decimal GetPrice()
        {
            return 1.1m + 0.2m;
        }

    }
}