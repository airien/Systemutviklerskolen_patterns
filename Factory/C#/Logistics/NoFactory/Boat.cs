using System.Text;

namespace NoFactory
{
    public class Boat
    {

        private readonly string _whatToDeliver;
        private readonly Coordinate[] _transportPoints;

        public Boat(string what, Coordinate[] transportPoints)
        {
            _whatToDeliver = what;
            _transportPoints = transportPoints;
        }

        public string Transport()
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
