package DataServiceNoDecorator;

import java.util.logging.Logger;

public class Program {
	public static void main(String[] args) {

        DataService dataService = new DataService(Logger.getLogger(Program.class.getName()));
        var text = dataService.getText();
	}
}
