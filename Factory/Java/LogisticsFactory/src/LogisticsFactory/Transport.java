package LogisticsFactory;

public abstract class Transport {
	protected String _type;
	protected String _whatToDeliver;
	protected Coordinate[] _transportPoints;
	
	public Transport(String type, String what, Coordinate[] transportPoints) {
		_type = type;
		_whatToDeliver = what;
		_transportPoints = transportPoints;
	}

	public String transport(){
		if(_transportPoints == null)
			return "No points to transport on";
		
		StringBuilder builder = new StringBuilder(String.format("Transporting by %s through points\n", _type));
		for(Coordinate c : _transportPoints) {
			builder.append(c.toString());
			builder.append(" ");
		}
		
		return builder.toString();
	}
	
	public String deliver()
	{
		return String.format("Delivering %s by %s",_whatToDeliver, _type);
	}
}
