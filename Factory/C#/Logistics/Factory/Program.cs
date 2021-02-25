using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport truck = LogisticsFactory.CreateTransport("road", "boxes", new Coordinate("Harbour", 1, 3), new Coordinate("Warehouse", 8, 45));
		
            var DoTransportPlan = truck.DoTransport();
            var delivery = truck.Deliver();
            Console.WriteLine("DoTransporting....");
            Console.WriteLine(DoTransportPlan);
            Console.WriteLine("delivering....");
            Console.WriteLine(delivery);
	
            Transport boat = LogisticsFactory.CreateTransport("sea", "lumber", new Coordinate("Harbour", 1, 3), new Coordinate("Warehouse", 45, 34));
		
            var boatDoTransportPlan = boat.DoTransport();
            var boatdelivery = boat.Deliver();
            Console.WriteLine("DoTransporting....");

            Console.WriteLine(boatDoTransportPlan);
            Console.WriteLine("delivering....");
            Console.WriteLine(boatdelivery);
		

            Transport air = LogisticsFactory.CreateTransport("air", "wonders", new Coordinate("Harbour", 1, 3), new Coordinate("Warehouse40", 256, 700));
		
            var airDoTransport = air.DoTransport();
            var airdelivery = air.Deliver();
            Console.WriteLine("DoTransporting....");

            Console.WriteLine(airDoTransport);
            Console.WriteLine("delivering....");
            Console.WriteLine(airdelivery);
        }
    }
}
