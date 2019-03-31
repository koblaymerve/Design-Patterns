using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Logger
{
    //3rd party log library
    public class log4net
    {
        public void LogMessage(string mes)
        {
            Console.WriteLine($"log4net {mes}");
        }
    }
}
