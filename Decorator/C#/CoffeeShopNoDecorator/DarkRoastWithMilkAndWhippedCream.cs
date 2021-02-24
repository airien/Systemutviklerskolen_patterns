namespace CoffeeShopNoDecorator
{
    public class DarkRoastWithMilkAndWhippedCream : Beverage
    {
        public DarkRoastWithMilkAndWhippedCream()
        {
            Description = "Dark roast with milk and whipped cream";
        }

        public override decimal GetPrice()
        {
            return 1.1m + 0.2m + 0.4m;
        }
    }
}