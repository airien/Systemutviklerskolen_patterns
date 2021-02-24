using System;

namespace CoffeeShopNoDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //House Blend With Milk
            var houseBlendWithMilk = new HouseBlendWithMilk();
            var price = houseBlendWithMilk.GetPrice();
            var description = houseBlendWithMilk.GetDescription();
            Console.WriteLine($"Ordered {description}. The price is: {price}");

            //Dark roast with milk and whip
            var coffee = new DarkRoastWithMilkAndWhippedCream();
           var price2 = coffee.GetPrice();
           var description2 = coffee.GetDescription();
            Console.WriteLine($"Ordered {description2}. The price is: {price2}");
        }
    }
}
