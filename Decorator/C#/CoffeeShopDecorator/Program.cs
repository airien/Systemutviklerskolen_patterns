using System;

namespace CoffeeShopDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order 1: houseblend with milk and 2xwhipped cream
            Beverage houseBlend = new HouseBlend();
            houseBlend = new MilkCondiment(houseBlend);
            houseBlend = new WhippedCreamCondiment(houseBlend);
            houseBlend = new WhippedCreamCondiment(houseBlend);
            var description = houseBlend.GetDescription();
            var price = houseBlend.GetPrice();

            Console.WriteLine($"Ordered {description}. The price is: {price}");

            //Order 2: darkroast with soy milk and whipped cream
            Beverage darkRoast = new DarkRoast();
            darkRoast = new SoyCondiment(darkRoast);
            darkRoast = new WhippedCreamCondiment(darkRoast);
            darkRoast = new ChocolateCondiment(darkRoast);
            var darkRoastDescription = darkRoast.GetDescription();
            var darkRoastPrice = darkRoast.GetPrice();

            Console.WriteLine($"darkRoastDescription {darkRoastDescription}. The price is: {darkRoastPrice}");
        }
    }
}
