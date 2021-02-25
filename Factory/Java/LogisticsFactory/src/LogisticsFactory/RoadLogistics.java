package LogisticsFactory;

public class RoadLogistics extends Logistics {

	@Override
	protected Transport createTransport(String whatToDeliver, Coordinate from, Coordinate to) {
		var transportPoints = planTransport(from, to);
		return new Truck(whatToDeliver, transportPoints);
	}

	@Override
	protected Coordinate[] planTransport(Coordinate from, Coordinate to) {
		return new Coordinate [] {from, new Coordinate("MainRoad", 4,7), to};
	}

}
