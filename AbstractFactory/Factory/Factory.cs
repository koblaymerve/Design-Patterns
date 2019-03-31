using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Factory : CrossCuttingConcernsFactory
    {
        public override Caching CreateCache()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new log4netLogger();
        }
    }
}
