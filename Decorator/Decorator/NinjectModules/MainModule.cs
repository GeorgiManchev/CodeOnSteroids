﻿using DecoratorExample.Contracts;
using DecoratorExample.Loggers;
using Ninject;
using Ninject.Modules;

namespace DecoratorExample.NinjectModules
{
    // Module, IOC container, Composer
    public class MainModule : NinjectModule
    {
        public override void Load()
        {
            //Single instance since it won`t change during runtime
            //Need to provide a name so that Ninject can supply the binding to the DecoratorExample
            this.Bind<ILogger>().To<ConsoleLogger>()
                .InSingletonScope()
                .Named(LoggerNames.ConsoleLogger);

            this.Bind<ILogger>().To<DateLoggerDecorator>()
                .InSingletonScope()
                .Named(LoggerNames.DateLogger)
                .WithConstructorArgument(this.Kernel.Get<ILogger>(LoggerNames.ConsoleLogger));
        }
    }
}
