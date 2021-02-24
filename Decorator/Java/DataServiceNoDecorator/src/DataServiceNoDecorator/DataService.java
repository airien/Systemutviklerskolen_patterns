package DataServiceNoDecorator;

import java.util.logging.Logger;

public class DataService implements IDataService
{
    private final Logger _logger;

    public DataService(Logger logger)
    {
        _logger = logger;
    }
    public String getText()
    {
        _logger.info("Start fetching text");
        var text = "Lorem ipsum";
        _logger.info("End fetching text");

        return text;
    }
}