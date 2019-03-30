using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DatabaseFactory
{
    public class DatabaseFactory : IDatabaseFactory
    {
        public IDatabaseConnector CreateDatabaseConnector()
        {
            //You can check web.config or any config, and you can create new instance with your configuration
            return new MongoDB.MongoDbConnector();
        }
    }
}
