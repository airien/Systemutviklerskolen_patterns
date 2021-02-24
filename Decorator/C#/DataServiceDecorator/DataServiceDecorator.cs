namespace DataServiceDecorator
{
    public abstract class DataServiceDecorator : DataServiceComponent
    {
        protected readonly DataServiceComponent DataService;

        protected DataServiceDecorator(DataServiceComponent dataService)
        {
            DataService = dataService;
        }
    }
}