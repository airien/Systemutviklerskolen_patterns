namespace Factory
{
    public class LogisticsFactory
    {
        private static readonly RoadLogistics Road = new RoadLogistics();
        private static readonly SeaLogistics Sea = new SeaLogistics();

        public static Transport CreateTransport(string type, string whatToDeliver, Coordinate[] transportPoints)
        {
            if (type.Equals("sea"))
                return Sea.CreateTransport(whatToDeliver, transportPoints);
            else if (type.Equals("road"))
                return Road.CreateTransport(whatToDeliver, transportPoints);

            return new UnknownTransport(whatToDeliver, null);
        }
    }
}