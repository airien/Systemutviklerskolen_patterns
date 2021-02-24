namespace CoffeeShopDecorator
{
    public class SugarCondiment : CondimentDecorator
    {
        public SugarCondiment(Beverage beverage) : base(beverage)
        {
            Description = "sugar";
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 88.0m;
        }
    }
}