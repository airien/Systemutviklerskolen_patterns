namespace Factory
{
    public class UnknownTransport : Transport
    {
        public UnknownTransport(string what, Coordinate[] transportPoints) : base("Unknown", "can't deliver no transport", transportPoints)
        {

        }
    }
}