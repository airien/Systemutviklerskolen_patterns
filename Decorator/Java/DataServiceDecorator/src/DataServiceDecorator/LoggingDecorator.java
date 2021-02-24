package DataServiceDecorator;

import java.util.logging.Logger;

public class LoggingDecorator extends DataServiceDecorator
{
    private final Logger _logger;

    public LoggingDecorator(DataServiceComponent dataService, Logger logger) {
    	super(dataService);
        _logger = logger;
    }

    @Override
    public String getText() {
        _logger.info("Start fetching text");
        var text = dataService.getText();
        _logger.info("End fetching text");
        return text;
    }
}
