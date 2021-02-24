package CoffeeShopNoDecorator;

public class Espresso extends Beverage
{
    public Espresso()
    {
        description = "Espresso";            
    }

    @Override
    public double getPrice()
    {
        return 1.2d;
    }
}