package LogisticsFactory;

public class LogisticsFactory {
	private static RoadLogistics road = new RoadLogistics();
	private static SeaLogistics sea = new SeaLogistics();
	
	public static Transport createTransport(String type, String whatToDeliver, Coordinate[] transportPoints)
	{
		if(type.equalsIgnoreCase("sea"))
			return sea.createTransport(whatToDeliver, transportPoints);
		else if(type.equalsIgnoreCase("road"))
			return road.createTransport(whatToDeliver, transportPoints);
		
		return new UnknownTransport(whatToDeliver, null);
	}
}
