namespace CoffeeShopNoDecorator
{
    public class Decaf :  Beverage
    {
        public Decaf()
        {
            Description = "Decaf";            
        }

        public override decimal GetPrice()
        {
            return 1.4m;
        }
    }
}
