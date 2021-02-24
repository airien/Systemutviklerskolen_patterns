namespace CoffeeShopNoDecorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House blend";
        }

        public override decimal GetPrice()
        {
            return 1.3m;
        }
    }
}