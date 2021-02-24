namespace Factory
{
    public abstract class Logistics
    {
        public abstract Transport CreateTransport(string whatToDeliver, Coordinate[] transportPoints);
    }
}