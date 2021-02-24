package LogisticsFactory;

public class RoadLogistics extends Logistics {

	@Override
	protected Transport createTransport(String whatToDeliver, Coordinate[] transportPoints) {
		// TODO Auto-generated method stub
		return new Truck(whatToDeliver, transportPoints);
	}

}
