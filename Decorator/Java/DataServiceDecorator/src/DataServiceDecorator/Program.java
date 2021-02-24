package DataServiceDecorator;

import java.util.logging.Logger;

public class Program {
    public static void main(String[] args) {
        //dataservice decrorated with logging
    	var logger = Logger.getLogger(Program.class.getName());

        DataServiceComponent dataService = new DataService();
        dataService = new LoggingDecorator(dataService, logger);

        var text = dataService.getText();
    }
}