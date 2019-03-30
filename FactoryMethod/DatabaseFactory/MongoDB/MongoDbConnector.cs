using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DatabaseFactory.MongoDB
{
    public class MongoDbConnector : IDatabaseConnector
    {
        public void Connect()
        {
            Console.WriteLine("Created MongoDB Connection !");
        }
    }
}
