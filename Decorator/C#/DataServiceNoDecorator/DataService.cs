using DataServiceNoDecorator.Infrastructure;

namespace DataServiceNoDecorator
{
    //Dataservice with logging
    public interface IDataService
    {
        string GetText();
    }

    public class DataService : IDataService
    {
        private readonly Logger _logger;

        public DataService(Logger logger)
        {
            _logger = logger;
        }
        public string GetText()
        {
            _logger.Log("Start fetching text");
            var text = "Lorem ipsum";
            _logger.Log("End fetching text");

            return text;
        }
    }
}
