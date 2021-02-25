namespace Factory
{
    public class RoadLogistics : Logistics
    {
        public override Transport CreateTransport(string whatToDeliver, Coordinate from, Coordinate to)
        {
            var transportPoints = PlanTransport(from, to);
            return new Truck(whatToDeliver, transportPoints);
        }

        protected override Coordinate[] PlanTransport(Coordinate from, Coordinate to)
        {
            return new Coordinate[] { from, new Coordinate("MainRoad", 4, 7), to };
        }
    }
}