namespace NoFactory
{
    public class Coordinate
    {
        private readonly string _name;
        private readonly double _x;
        private readonly double _y;

        public Coordinate(string name, double x, double y)
        {
            _name = name;
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"{_name} {_x} {_y}";
        }

    }
}