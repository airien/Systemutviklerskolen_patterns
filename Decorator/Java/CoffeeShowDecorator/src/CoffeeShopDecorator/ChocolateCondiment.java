package CoffeeShopDecorator;

//ConcreteDecorator
public class ChocolateCondiment extends CondimentDecorator
{
    public ChocolateCondiment(Beverage beverage) 
    {
    	super(beverage);
        description = "chocolate";
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