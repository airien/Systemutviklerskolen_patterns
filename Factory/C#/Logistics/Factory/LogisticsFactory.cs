namespace Factory
{
    public class LogisticsFactory
    {
        private static readonly RoadLogistics Road = new RoadLogistics();
        private static readonly SeaLogistics Sea = new SeaLogistics();
        private static readonly AirLogistics Air = new AirLogistics();

        public static Transport CreateTransport(string type, string whatToDeliver, Coordinate from, Coordinate to)
        {
            if (type.Equals("sea"))
                return Sea.CreateTransport(whatToDeliver, from, to);
            else if (type.Equals("road"))
                return Road.CreateTransport(whatToDeliver, from, to);
            else if(type.Equals("air"))
                return Air.CreateTransport(whatToDeliver, from, to);

            return new UnknownTransport(whatToDeliver, null);
        }
    }
}