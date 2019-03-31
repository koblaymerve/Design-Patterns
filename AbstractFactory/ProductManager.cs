using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ProductManager
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        Logging _logging;
        Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = crossCuttingConcernsFactory.CreateLogger();
            _caching = crossCuttingConcernsFactory.CreateCache();
        }

        public void GetAll()
        {
            _logging.Log();
            _caching.Cache("Hello!");
            Console.WriteLine("Products listed !");
        }
    }
}
