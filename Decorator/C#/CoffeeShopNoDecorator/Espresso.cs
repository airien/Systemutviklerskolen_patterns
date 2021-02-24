namespace CoffeeShopNoDecorator
{
    public class Espresso :  Beverage
    {
        public Espresso()
        {
            Description = "Espresso";            
        }

        public override decimal GetPrice()
        {
            return 1.2m;
        }
    }
}