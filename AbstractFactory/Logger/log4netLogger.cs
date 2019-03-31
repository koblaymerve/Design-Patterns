using System;

namespace AbstractFactory
{
    class log4netLogger : Logging
    {
        public override void Log()
        {
            Console.WriteLine("log4net logged");
        }
    }
}
