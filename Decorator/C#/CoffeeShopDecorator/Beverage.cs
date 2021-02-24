namespace CoffeeShopDecorator
{
    //Component
    public abstract class Beverage  
    {
        protected string Description = "";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract decimal GetPrice();
    }
}