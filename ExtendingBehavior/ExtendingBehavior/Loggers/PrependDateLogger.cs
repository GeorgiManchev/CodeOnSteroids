using ExtendingBehavior.Contracts;
using System;

namespace ExtendingBehavior.Loggers
{
    public class PrependDateLogger : ILogger
    {
        //logger to be decorated/extended
        private readonly ILogger logger;

        public PrependDateLogger(ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException("Logger");
        }

        //decorate/extend existing logic without changing its implementation
        public void Log(string message)
        {
            //some new logic
            var decoratedMessage = $"{DateTime.UtcNow}: {message}";
            this.logger.Log(decoratedMessage);
            //or here
        }
    }
}
