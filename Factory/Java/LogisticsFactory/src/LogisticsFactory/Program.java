package LogisticsFactory;


public class Program {
	public static void main(String[] args) {
		var coords = new Coordinate[3];
		coords[0] = new Coordinate("Harbour", 1,3);
		coords[1] = new Coordinate("MainRoad", 4,7);
		coords[2] = new Coordinate("Warehouse", 8,45);
		Transport truck = LogisticsFactory.createTransport("road", "boxes", coords);
		
		var transportPlan = truck.transport();
		var delivery = truck.deliver();
		System.out.println("transporting....");
		System.out.println(transportPlan);
		System.out.println("delivering....");
		System.out.println(delivery);
		
		
		var boatCoords = new Coordinate[3];
		boatCoords[0] = new Coordinate("Harbour", 1,3);
		boatCoords[1] = new Coordinate("River", 2,7);
		boatCoords[2] = new Coordinate("Warehouse1", 40,34);
		boatCoords[2] = new Coordinate("Warehouse2", 43,34);
		boatCoords[2] = new Coordinate("Warehous3e", 45,34);
		Transport boat = LogisticsFactory.createTransport("sea", "lumber", boatCoords);
		
		var boattransportPlan = boat.transport();
		var boatdelivery = boat.deliver();
		System.out.println("transporting....");

		System.out.println(boattransportPlan);
		System.out.println("delivering....");
		System.out.println(boatdelivery);
		

		var airCoords = new Coordinate[3];
		airCoords[0] = new Coordinate("Harbour", 1,3);
		airCoords[1] = new Coordinate("River", 2,7);
		Transport air = LogisticsFactory.createTransport("air", "wonders", airCoords);
		
		var airTransport = air.transport();
		var airdelivery = air.deliver();
		System.out.println("transporting....");

		System.out.println(airTransport);
		System.out.println("delivering....");
		System.out.println(airdelivery);
		
	}
}
