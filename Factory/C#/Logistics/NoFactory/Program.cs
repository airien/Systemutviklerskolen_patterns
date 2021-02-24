using System;

namespace NoFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var coords = new Coordinate[3];
            coords[0] = new Coordinate("Harbour", 1,3);
            coords[1] = new Coordinate("MainRoad", 4,7);
            coords[2] = new Coordinate("Warehouse", 8,45);
            Truck truck = new Truck("Package", coords);
		
            var transportPlan = truck.Transport();
            var delivery = truck.Deliver();
            Console.WriteLine("transporting....");

            Console.WriteLine(transportPlan);
            Console.WriteLine("delivering....");
            Console.WriteLine(delivery);
		
		
            var boatCoords = new Coordinate[3];
            boatCoords[0] = new Coordinate("Harbour", 1,3);
            boatCoords[1] = new Coordinate("River", 2,7);
            boatCoords[2] = new Coordinate("Warehouse", 45,34);
            Boat boat = new Boat("Lumber", boatCoords);
		
            var boattransportPlan = boat.Transport();
            var boatdelivery = boat.Deliver();
            Console.WriteLine("transporting....");

            Console.WriteLine(boattransportPlan);
            Console.WriteLine("delivering....");
            Console.WriteLine(boatdelivery);
        }
    }
}
