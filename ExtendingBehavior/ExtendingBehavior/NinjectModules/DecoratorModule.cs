using ExtendingBehavior.Contracts;
using ExtendingBehavior.Loggers;
using Ninject;
using Ninject.Modules;

namespace ExtendingBehavior.NinjectModules
{
    // Module, IOC container, Composer
    public class DecoratorModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ILogger>().To<ConsoleLogger>()
                .InSingletonScope()
                .Named("ConsoleLogger");

            this.Bind<ILogger>().To<PrependDateLogger>()
                .InSingletonScope()
                .Named("PrependDateLogger")
                .WithConstructorArgument(this.Kernel.Get<ILogger>("ConsoleLogger"));
        }
    }
}
