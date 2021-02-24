namespace CoffeeShopDecorator
{
    //ConcreteDecorator
    public class WhippedCreamCondiment : CondimentDecorator
    {
        public WhippedCreamCondiment(Beverage beverage) : base(beverage)
        {
            Description = "whipped cream";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 0.4m;
        }

    }
}