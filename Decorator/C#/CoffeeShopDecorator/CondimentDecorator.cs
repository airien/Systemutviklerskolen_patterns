namespace CoffeeShopDecorator
{
    //Decorator
    public abstract class CondimentDecorator : Beverage 
    {
        protected readonly Beverage WrappedBeverage;

        protected CondimentDecorator(Beverage beverage)
        {
            WrappedBeverage = beverage;
            Description = "Undefined condiment";
        }

        public override decimal GetPrice()
        {
            return WrappedBeverage.GetPrice();
        }

        public override string GetDescription()
        {
            return WrappedBeverage.GetDescription();
        }
    }
}