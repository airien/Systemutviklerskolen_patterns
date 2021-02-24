package LogisticsFactory;

public abstract class Logistics {
	protected abstract Transport createTransport(String whatToDeliver, Coordinate[] transportPoints);
}
