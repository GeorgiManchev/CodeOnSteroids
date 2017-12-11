using DecoratorExample.Contracts;
using System;

namespace DecoratorExample.Loggers
{
    public class DateLoggerDecorator : ILogger
    {
        private readonly ILogger logger;

        //Get the class to be decorated/extended
        public DateLoggerDecorator(ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException("Logger");
        }

        //Decorate existing logic without changing its implementation
        public void Log(string message)
        {
            var decoratedMessage = $"{DateTime.UtcNow}: {message}";
            this.logger.Log(decoratedMessage);
        }
    }
}
