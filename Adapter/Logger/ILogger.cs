using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Logger
{
    interface ILogger
    {
        void Logger(string message);
    }
}
