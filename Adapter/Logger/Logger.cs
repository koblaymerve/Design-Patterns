using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Logger
{
    class Logger : ILogger
    {
        void ILogger.Logger(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}
