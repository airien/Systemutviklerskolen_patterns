namespace CoffeeShopDecorator
{
    //ConcreteDecorator
    public class SoyCondiment : CondimentDecorator
    {
        public SoyCondiment(Beverage beverage) : base(beverage)
        {
            Description = "soy";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 0.2m;
        }
    }
}