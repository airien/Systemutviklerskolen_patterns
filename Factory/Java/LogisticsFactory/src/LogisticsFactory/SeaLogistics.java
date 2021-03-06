package LogisticsFactory;

public class SeaLogistics extends Logistics {
	
	@Override
	protected Transport createTransport(String whatToDeliver, Coordinate from, Coordinate to) {
		var transportPoints = planTransport(from, to);
		return new Boat(whatToDeliver, transportPoints);
	}

	@Override
	protected Coordinate[] planTransport(Coordinate from, Coordinate to) {
		return new Coordinate [] {from,  new Coordinate("River", 2,7), new Coordinate("Warehouse1", 40,34), new Coordinate("Warehouse2", 43,34), to};
	}
}
