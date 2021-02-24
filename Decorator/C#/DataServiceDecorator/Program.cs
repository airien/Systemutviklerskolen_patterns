using System;
using DataServiceDecorator.Infrastructure;

namespace DataServiceDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //dataservice decrorated with logging
            var logger = new Logger();

            DataServiceComponent dataService = new DataService();
            dataService = new LoggingDecorator(dataService, logger);

            var text = dataService.GetText();
        }
    }
}
