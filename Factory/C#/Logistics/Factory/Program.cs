using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var coords = new Coordinate[3];
            coords[0] = new Coordinate("Harbour", 1,3);
            coords[1] = new Coordinate("MainRoad", 4,7);
            coords[2] = new Coordinate("Warehouse", 8,45);
            Transport truck = LogisticsFactory.CreateTransport("road", "boxes", coords);
		
            var DoTransportPlan = truck.DoTransport();
            var delivery = truck.Deliver();
            Console.WriteLine("DoTransporting....");
            Console.WriteLine(DoTransportPlan);
            Console.WriteLine("delivering....");
            Console.WriteLine(delivery);
		
		
            var boatCoords = new Coordinate[3];
            boatCoords[0] = new Coordinate("Harbour", 1,3);
            boatCoords[1] = new Coordinate("River", 2,7);
            boatCoords[2] = new Coordinate("Warehouse1", 40,34);
            boatCoords[2] = new Coordinate("Warehouse2", 43,34);
            boatCoords[2] = new Coordinate("Warehous3e", 45,34);
            Transport boat = LogisticsFactory.CreateTransport("sea", "lumber", boatCoords);
		
            var boatDoTransportPlan = boat.DoTransport();
            var boatdelivery = boat.Deliver();
            Console.WriteLine("DoTransporting....");

            Console.WriteLine(boatDoTransportPlan);
            Console.WriteLine("delivering....");
            Console.WriteLine(boatdelivery);
		

            var airCoords = new Coordinate[3];
            airCoords[0] = new Coordinate("Harbour", 1,3);
            airCoords[1] = new Coordinate("River", 2,7);
            Transport air = LogisticsFactory.CreateTransport("air", "wonders", airCoords);
		
            var airDoTransport = air.DoTransport();
            var airdelivery = air.Deliver();
            Console.WriteLine("DoTransporting....");

            Console.WriteLine(airDoTransport);
            Console.WriteLine("delivering....");
            Console.WriteLine(airdelivery);
        }
    }
}
