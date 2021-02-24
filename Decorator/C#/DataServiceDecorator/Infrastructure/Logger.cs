using System;

namespace DataServiceDecorator.Infrastructure
{
    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}