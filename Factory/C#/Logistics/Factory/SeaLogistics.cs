namespace Factory
{
    public class SeaLogistics : Logistics
    {
        public override Transport CreateTransport(string whatToDeliver, Coordinate[] transportPoints)
        {
            return new Boat(whatToDeliver, transportPoints);
        }
    }

    public class RoadLogistics : Logistics
    {
        public override Transport CreateTransport(string whatToDeliver, Coordinate[] transportPoints)
        {
            return new Truck(whatToDeliver, transportPoints);
        }
    }
}