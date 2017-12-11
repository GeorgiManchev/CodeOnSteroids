using DecoratorExample.Contracts;
using DecoratorExample.NinjectModules;
using Ninject;

namespace DecoratorExample
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var module = new MainModule();
            var kernel = new StandardKernel(module);

            //var logger = kernel.Get<ILogger>(LoggerNames.ConsoleLogger); //Console Logger
            var logger = kernel.Get<ILogger>(LoggerNames.DateLogger); //Decorated Console Logger

            //what we gain: In our entire program, where we use ILogger.Log()
            //we won`t change enything and still have the new extended functionality
            logger.Log("Some message to be logged");
        }
    }
}
