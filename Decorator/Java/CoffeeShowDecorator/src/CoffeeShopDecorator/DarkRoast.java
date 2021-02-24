package CoffeeShopDecorator;

public class DarkRoast extends Beverage
{
    public DarkRoast()
    {
        description = "Dark roast";            
    }

	@Override
    public double getPrice()
    {
        return 1.1d;
    }
}