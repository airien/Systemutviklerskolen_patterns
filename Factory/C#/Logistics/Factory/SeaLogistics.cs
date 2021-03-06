﻿namespace Factory
{
    public class SeaLogistics : Logistics
    {
        public override Transport CreateTransport(string whatToDeliver, Coordinate from, Coordinate to)
        {
            var transportPoints = PlanTransport(from, to);
            return new Boat(whatToDeliver, transportPoints);
        }

        protected override Coordinate[] PlanTransport(Coordinate from, Coordinate to)
        {
            return new Coordinate[] { from, new Coordinate("River", 2, 7), new Coordinate("Warehouse1", 40, 34), new Coordinate("Warehouse2", 43, 34), to };
        }
    }
}