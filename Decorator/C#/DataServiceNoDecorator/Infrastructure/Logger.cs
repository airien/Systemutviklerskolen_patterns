using System;

namespace DataServiceNoDecorator.Infrastructure
{
    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}