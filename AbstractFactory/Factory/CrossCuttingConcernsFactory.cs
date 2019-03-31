using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCache();
    }
}
