using DataServiceDecorator.Infrastructure;

namespace DataServiceDecorator
{
    public class LoggingDecorator : DataServiceDecorator
    {
        private readonly Logger _logger;

        public LoggingDecorator(DataServiceComponent dataService, Logger logger) : base(dataService)
        {
            _logger = logger;
        }

        public override string GetText()
        {
            _logger.Log("Start fetching text");
            var text = DataService.GetText();
            _logger.Log("End fetching text");
            return text;
        }
    }
}