namespace FactoryMethod
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new MkLogger();
        }
    }
}
