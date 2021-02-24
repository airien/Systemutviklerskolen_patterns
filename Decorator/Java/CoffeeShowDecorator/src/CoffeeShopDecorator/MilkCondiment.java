package CoffeeShopDecorator;

//ConcreteDecorator
public class MilkCondiment extends CondimentDecorator
{
    public MilkCondiment(Beverage beverage) 
    {
    	super(beverage);
        description = "milk";
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