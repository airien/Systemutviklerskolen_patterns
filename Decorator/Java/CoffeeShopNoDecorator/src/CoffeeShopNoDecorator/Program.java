package CoffeeShopNoDecorator;

public class Program {
	public static void main(String[] args){
		System.out.println("Welcome to the coffee stand");
		
        //House Blend With Milk
        var houseBlendWithMilk = new HouseBlendWithMilk();
        var price = houseBlendWithMilk.getPrice();
        var description = houseBlendWithMilk.getDescription();
        System.out.println(String.format("Ordered %s. The price is: %.2f",description, price));
        
       //Dark roast with milk and whip
       var coffee = new DarkRoastWithMilkAndWhippedCream();
       var price2 = coffee.getPrice();
       var description2 = coffee.getDescription();
       System.out.println(String.format("Ordered %s. The price is: %.2f",description2, price2));
	}
}
