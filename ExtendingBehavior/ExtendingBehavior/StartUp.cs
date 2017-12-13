using ExtendingBehavior.Contracts;
using ExtendingBehavior.NinjectModules;
using Ninject;

namespace ExtendingBehavior
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //var logger = DecoratorExmple();
            var logger = CompositeExample();
            //var logger = InterceptorExample();

            //what we gain: In our entire program, where we use ILogger.Log()
            //we won`t change enything and still have the additional functionality or behavior
            logger.Log("Some message to be logged");
        }

        public static ILogger DecoratorExmple()
        {
            var module = new DecoratorModule();
            var kernel = new StandardKernel(module);

            return kernel.Get<ILogger>();
        }

        public static ILogger CompositeExample()
        {
            var module = new CompositeModule();
            var kernel = new StandardKernel(module);

            return kernel.Get<ILogger>();
        }

        public static ILogger InterceptorExample()
        {
            var module = new InterceptorModule();
            var kernel = new StandardKernel(module);

            return kernel.Get<ILogger>();
        }
    }
}
