using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
}
