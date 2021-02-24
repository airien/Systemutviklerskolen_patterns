package CoffeeShopDecorator;

public class Program {

	public static void main(String[] args) {
        //Order 1: houseblend with milk and 2xwhipped cream
        Beverage houseBlend = new HouseBlend();
        houseBlend = new MilkCondiment(houseBlend);
        houseBlend = new WhippedCreamCondiment(houseBlend);
        houseBlend = new WhippedCreamCondiment(houseBlend);
        var description = houseBlend.getDescription();
        var price = houseBlend.getPrice();
        System.out.println(String.format("Ordered %s. The price is: %.2f",description, price));

        //Order 2: darkroast with soy milk and whipped cream
        Beverage darkRoast = new DarkRoast();
        darkRoast = new SoyCondiment(darkRoast);
        darkRoast = new WhippedCreamCondiment(darkRoast);
        darkRoast = new ChocolateCondiment(darkRoast);
        var darkRoastDescription = darkRoast.getDescription();
        var darkRoastPrice = darkRoast.getPrice();
        System.out.println(String.format("Ordered %s. The price is: %.2f",darkRoastDescription, darkRoastPrice));
	}
}
