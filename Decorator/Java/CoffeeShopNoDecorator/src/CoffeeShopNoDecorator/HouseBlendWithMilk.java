package CoffeeShopNoDecorator;

public class HouseBlendWithMilk extends Beverage
{
    public HouseBlendWithMilk()
    {
        description = "House blend with milk";
    }

    @Override
    public double getPrice()
    {
        return 1.3d + 0.2d;
    }
}