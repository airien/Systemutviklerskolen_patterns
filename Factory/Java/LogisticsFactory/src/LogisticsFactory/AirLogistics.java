package LogisticsFactory;

public class AirLogistics extends Logistics  {

	@Override
	protected Transport createTransport(String whatToDeliver, Coordinate from, Coordinate to) {
		var transportPoints = planTransport(from, to);
		return new Plane(whatToDeliver, transportPoints);
	}

	@Override
	protected Coordinate[] planTransport(Coordinate from, Coordinate to) {

		return new Coordinate [] {from, to};
	}

}
