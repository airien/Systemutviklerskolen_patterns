package CoffeeShopNoDecorator;

public class DarkRoastWithMilkAndWhippedCream extends Beverage
{
    public DarkRoastWithMilkAndWhippedCream()
    {
        description = "Dark roast with milk and whipped cream";
    }

    @Override
    public double getPrice()
    {
        return 1.1d + 0.2d + 0.4d;
    }
}