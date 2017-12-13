using ExtendingBehavior.Contracts;
using System;
using System.Collections.Generic;

namespace ExtendingBehavior.Loggers
{
    public class CompositeLogger : ILogger
    {
        //collection of loggers to be decorated/extended
        private readonly IEnumerable<ILogger> loggers;

        //instead of extending one Logger we extend an entire collection of Loggers
        public CompositeLogger(IEnumerable<ILogger> loggers)
        {
            this.loggers = loggers ?? throw new ArgumentNullException("Loggers is null");
        }

        //same as the Decorator
        public void Log(string message)
        {
            //some new logic here

            foreach (var item in this.loggers)
            {
                //some new logic here
                item.Log("Composite example");
                item.Log(message);
            }

            //or here
        }
    }
}
