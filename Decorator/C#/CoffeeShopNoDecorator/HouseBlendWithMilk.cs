namespace CoffeeShopNoDecorator
{
    public class HouseBlendWithMilk : Beverage
    {
        public HouseBlendWithMilk()
        {
            Description = "House blend with milk";
        }

        public override decimal GetPrice()
        {
            return 1.3m + 0.2m;
        }
    }
}