using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Plane : Transport
    {
        public Plane(String what, Coordinate[] transportPoints) : base("Plane", what, transportPoints)
        {
        }
    }
}
