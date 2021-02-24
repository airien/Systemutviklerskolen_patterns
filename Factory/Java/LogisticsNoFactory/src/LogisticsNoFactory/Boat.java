package LogisticsNoFactory;

import LogisticsNoFactory.Coordinate;

public class Boat {

	private String _whatToDeliver;
	private Coordinate[] _transportPoints;
	
	public Boat(String what, Coordinate[] transportPoints) {
		_whatToDeliver = what;
		_transportPoints = transportPoints;
	}
	
	public String transport(){
		StringBuilder builder = new StringBuilder("Transporting by boat through points\n");
		for(Coordinate c : _transportPoints)
			builder.append(c.toString());
		
		return builder.toString();
		
	}
	
	public String deliver()
	{
		return String.format("Delivering %s by Boat",_whatToDeliver);
	}
}
