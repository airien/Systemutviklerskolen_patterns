namespace CoffeeShopDecorator
{
    //ConcreteDecorator
    public class ChocolateCondiment : CondimentDecorator
    {
        public ChocolateCondiment(Beverage beverage) : base(beverage)
        {
            Description = "chocolate";
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