package LogisticsNoFactory;

import LogisticsNoFactory.Boat;
import LogisticsNoFactory.Truck;

public class Program {
	public static void main(String[] args) {
		var coords = new Coordinate[3];
		coords[0] = new Coordinate("Harbour", 1,3);
		coords[1] = new Coordinate("MainRoad", 4,7);
		coords[2] = new Coordinate("Warehouse", 8,45);
		Truck truck = new Truck("Package", coords);
		
		var transportPlan = truck.transport();
		var delivery = truck.deliver();
		System.out.println("transporting....");

		System.out.println(transportPlan);
		System.out.println("delivering....");
		System.out.println(delivery);
		
		
		var boatCoords = new Coordinate[3];
		boatCoords[0] = new Coordinate("Harbour", 1,3);
		boatCoords[1] = new Coordinate("River", 2,7);
		boatCoords[2] = new Coordinate("Warehouse", 45,34);
		Boat boat = new Boat("Lumber", boatCoords);
		
		var boattransportPlan = boat.transport();
		var boatdelivery = boat.deliver();
		System.out.println("transporting....");

		System.out.println(boattransportPlan);
		System.out.println("delivering....");
		System.out.println(boatdelivery);
		
	}
}
