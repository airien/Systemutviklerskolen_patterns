namespace Factory
{
    public abstract class Logistics
    {
        public abstract Transport CreateTransport(string whatToDeliver, Coordinate from, Coordinate to);
        protected abstract Coordinate[] PlanTransport(Coordinate from, Coordinate to);
    }
}