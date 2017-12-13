using ExtendingBehavior.Contracts;
using ExtendingBehavior.Loggers;
using Ninject.Modules;
using System.Collections.Generic;

namespace ExtendingBehavior.NinjectModules
{
    public class CompositeModule : NinjectModule
    {
        public override void Load()
        {
            var loggers = new List<ILogger>();
            var consoleLogger =  new ConsoleLogger();
            var decoratedConsoleLogger = new PrependDateLogger(consoleLogger);
            var fileLogger = new TextFileLogger();
            var decoratedFileLogger = new PrependDateLogger(fileLogger);

            loggers.Add(consoleLogger);
            loggers.Add(decoratedConsoleLogger);
            loggers.Add(fileLogger);
            loggers.Add(decoratedFileLogger);

            this.Bind<ILogger>().To<CompositeLogger>().WithConstructorArgument(loggers);

        }
    }
}
