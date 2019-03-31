using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }
}
