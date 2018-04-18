namespace FactoryMethod
{
    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new log4netLogger();
        }
    }
}
