using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Logger
{
    //3rd party bir kütüphanenin gerekli metodunu kapsüllemiş olduk.
    class LoggerAdapter : ILogger
    {
        private log4net _log4Net;

        public void Logger(string message)
        {
            _log4Net = new log4net();
            _log4Net.LogMessage(message);
        }
    }
}
