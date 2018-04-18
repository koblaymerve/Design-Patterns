using System;

namespace FactoryMethod
{
    public class MkLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with MkLogger");
        }
    }

}
