package LogisticsFactory;

public abstract class Logistics {
	protected abstract Transport createTransport(String whatToDeliver, Coordinate from, Coordinate to);
	protected abstract Coordinate[] planTransport(Coordinate from, Coordinate to);
}
