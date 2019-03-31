using Adapter.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Logger("User Data");
            Console.WriteLine("Saved");
        }
    }
}
