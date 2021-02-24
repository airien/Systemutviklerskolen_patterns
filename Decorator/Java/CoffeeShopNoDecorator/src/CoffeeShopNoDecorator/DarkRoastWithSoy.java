package CoffeeShopNoDecorator;

public class DarkRoastWithSoy extends Beverage
{
    public DarkRoastWithSoy()
    {
        description = "Dark roast with soy milk";            
    }

    @Override
    public double getPrice()
    {
        return 1.1d;
    }
}