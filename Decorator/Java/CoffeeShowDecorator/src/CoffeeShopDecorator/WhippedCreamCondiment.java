package CoffeeShopDecorator;

//ConcreteDecorator
public class WhippedCreamCondiment extends CondimentDecorator
{
    public WhippedCreamCondiment(Beverage beverage) 
    {
    	super(beverage);
        description = "whipped cream";
    }

    @Override
    public double getPrice()
    {
        return wrappedBeverage.getPrice() + 0.4d;
    }

    @Override
    public String getDescription()
    {
        return String.format("%s, %s", wrappedBeverage.getDescription(), description);
    }
}