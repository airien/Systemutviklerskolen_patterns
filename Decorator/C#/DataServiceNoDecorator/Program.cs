using System;
using DataServiceNoDecorator.Infrastructure;

namespace DataServiceNoDecorator
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            DataService dataService = new DataService(new Logger());
            var text = dataService.GetText();
        }
    }
}
