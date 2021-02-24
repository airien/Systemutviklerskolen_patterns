package LogisticsFactory;

public class UnknownTransport extends Transport{
	public UnknownTransport(String what, Coordinate[] transportPoints) {
		super("Unknown", "can't deliver no transport", null);
	}
}
