package LogisticsFactory;

public class LogisticsFactory {
	private static RoadLogistics road = new RoadLogistics();
	private static SeaLogistics sea = new SeaLogistics();
	private static AirLogistics air = new AirLogistics();
	
	public static Transport createTransport(String type, String whatToDeliver, Coordinate from, Coordinate to)
	{
		if(type.equalsIgnoreCase("sea"))
			return sea.createTransport(whatToDeliver, from, to);
		else if(type.equalsIgnoreCase("road"))
			return road.createTransport(whatToDeliver, from, to);
		else if(type.equalsIgnoreCase("air"))
			return air.createTransport(whatToDeliver, from, to);
		
		return new UnknownTransport(whatToDeliver, null);
	}
}
