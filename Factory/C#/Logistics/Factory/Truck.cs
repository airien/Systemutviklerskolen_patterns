namespace Factory
{
    public class Truck : Transport
    {
        public Truck(string what, Coordinate[] transportPoints) : base("Truck", what, transportPoints)
        {

        }
    }
}