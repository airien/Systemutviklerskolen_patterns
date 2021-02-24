using System.Text;

namespace Factory
{
    public class Transport
    {
        private readonly string _type;
        private readonly string _whatToDeliver;
        private readonly Coordinate[] _transportPoints;

        public Transport(string type, string what, Coordinate[] transportPoints)
        {
            _type = type;
            _whatToDeliver = what;
            _transportPoints = transportPoints;
        }

        public string DoTransport()
        {
            var builder = new StringBuilder("Transporting by boat through points\n");

            foreach (var transportPoint in _transportPoints)
            {
                builder.Append(transportPoint);
            }

            return builder.ToString();

        }

        public string Deliver()
        {
            return $"Delivering {_whatToDeliver}s by Boat";
        }
    }
}
