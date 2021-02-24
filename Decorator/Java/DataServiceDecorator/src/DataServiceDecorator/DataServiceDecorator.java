package DataServiceDecorator;

public abstract class DataServiceDecorator extends DataServiceComponent
{
    protected final DataServiceComponent dataService;

    protected DataServiceDecorator(DataServiceComponent dataService)
    {
        this.dataService = dataService;
    }
}