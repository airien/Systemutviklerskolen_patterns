package CoffeeShopDecorator;

public class Decaf extends Beverage
{
    public Decaf()
    {
        description = "Decaf";            
    }

    public double getPrice()
    {
        return 1.4d;
    }
}