package CoffeeShopDecorator;

//ConcreteDecorator
public class SoyCondiment extends CondimentDecorator
{
    public SoyCondiment(Beverage beverage) 
    {
    	super(beverage);
        description = "soy";
    }

    @Override
    public double getPrice()
    {
        return wrappedBeverage.getPrice() + 0.2d;
    }

    @Override
    public String getDescription()
    {
        return String.format("%s, %s", wrappedBeverage.getDescription(), description);
    }
}