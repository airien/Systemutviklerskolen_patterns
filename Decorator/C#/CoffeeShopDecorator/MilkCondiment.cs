namespace CoffeeShopDecorator
{
    //ConcreteDecorator
    public class MilkCondiment : CondimentDecorator
    {
        public MilkCondiment(Beverage beverage) : base(beverage)
        {
            Description = "milk";
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