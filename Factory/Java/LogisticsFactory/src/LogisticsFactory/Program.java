package LogisticsFactory;


public class Program {
	public static void main(String[] args) {
		Transport truck = LogisticsFactory.createTransport("road", "boxes", new Coordinate("Harbour", 1,3), new Coordinate("Warehouse", 8,45));
		var transportPlan = truck.transport();
		var delivery = truck.deliver();
		System.out.println("transporting....");
		System.out.println(transportPlan);
		System.out.println("delivering....");
		System.out.println(delivery);
		
		
		Transport boat = LogisticsFactory.createTransport("sea", "lumber", new Coordinate("Harbour", 1,3), new Coordinate("Warehouse", 45,34));
		
		var boattransportPlan = boat.transport();
		var boatdelivery = boat.deliver();
		System.out.println("transporting....");

		System.out.println(boattransportPlan);
		System.out.println("delivering....");
		System.out.println(boatdelivery);
		
		Transport air = LogisticsFactory.createTransport("air", "wonders", new Coordinate("Harbour", 1,3), new Coordinate("Warehouse", 2,7));
		
		var airTransport = air.transport();
		var airdelivery = air.deliver();
		System.out.println("transporting....");

		System.out.println(airTransport);
		System.out.println("delivering....");
		System.out.println(airdelivery);
		
	}
}
