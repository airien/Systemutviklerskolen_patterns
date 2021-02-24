using System;
using System.Collections.Generic;
using System.Text;

namespace NoFactory
{
    public class Truck
    {
        private readonly string _whatToDeliver;
        private readonly Coordinate[] _transportPoints;

        public Truck(string what, Coordinate[] transportPoints)
        {
            _whatToDeliver = what;
            _transportPoints = transportPoints;
        }

        public string Transport()
        {
            var builder = new StringBuilder("Transporting by truck through points\n");

            foreach (var transportPoint in _transportPoints)
            {
                builder.Append(transportPoint);
            }

            return builder.ToString();

        }

        public string Deliver()
        {
            return $"Delivering {_whatToDeliver}s by truck";
        }
    }
}
