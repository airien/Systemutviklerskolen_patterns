package CoffeeShopDecorator;

//Decorator
public abstract class CondimentDecorator extends Beverage 
{
    protected final Beverage wrappedBeverage;

    protected CondimentDecorator(Beverage beverage)
    {
        wrappedBeverage = beverage;
        description = "Undefined condiment";
    }

    @Override
    public double getPrice()
    {
        return wrappedBeverage.getPrice() + 0.5d;
    }

    @Override
    public String getDescription()
    {
        return String.format("%s, %s", wrappedBeverage.getDescription(), description);
    }
}