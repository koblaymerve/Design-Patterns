using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreateCache()
        {
            return new MemCache();
        }

        public override Logging CreateLogger()
        {
            return new NLogger();
        }
    }
}
