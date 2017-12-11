using DecoratorExample.Contracts;
using System;

namespace DecoratorExample.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
