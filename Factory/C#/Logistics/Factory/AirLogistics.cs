using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class AirLogistics : Logistics
    {
        public override Transport CreateTransport(string whatToDeliver, Coordinate from, Coordinate to)
        {
            var transportPoints = PlanTransport(from, to);
            return new Plane(whatToDeliver, transportPoints);
        }

        protected override Coordinate[] PlanTransport(Coordinate from, Coordinate to)
        {
            return new Coordinate[] { from, to };
        }
    }
}
