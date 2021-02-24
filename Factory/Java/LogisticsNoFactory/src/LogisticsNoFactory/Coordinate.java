package LogisticsNoFactory;

public class Coordinate {
	private String _name;
	private double _x;
	private double _y;
	
	public Coordinate(String name, double x, double y)
	{
		_name = name;
		_x = x;
		_y = y;
	}
	
	@Override
	public String toString()
	{
		return String.format("%s %.8f %.8f", _name, _x, _y);
	}
	
}
