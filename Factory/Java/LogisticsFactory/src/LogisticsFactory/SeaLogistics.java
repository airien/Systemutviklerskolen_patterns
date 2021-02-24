package LogisticsFactory;

public class SeaLogistics extends Logistics {
	
	@Override
	protected Transport createTransport(String whatToDeliver, Coordinate[] transportPoints) {
		return new Boat(whatToDeliver, transportPoints);
	}
}
