package CoffeeShopNoDecorator;

public class DarkRoastWithMilk extends Beverage
{
    public DarkRoastWithMilk()
    {
        description = "Dark roast with milk";
    }

	@Override
    public double getPrice()
    {
        return 1.1d + 0.2d;
    }


}