using System;

namespace AbstractFactory
{
    class NLogger : Logging
    {
        public override void Log()
        {
            Console.WriteLine("NLogger logged");
        }
    }
}
