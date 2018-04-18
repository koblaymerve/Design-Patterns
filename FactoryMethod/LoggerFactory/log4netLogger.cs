using System;

namespace FactoryMethod
{
    public class log4netLogger :ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with log4netLogger");
        }
    }

}
