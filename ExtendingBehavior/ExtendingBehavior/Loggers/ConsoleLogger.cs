using ExtendingBehavior.Contracts;
using System;

namespace ExtendingBehavior.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
