using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DatabaseFactory.PostgreSQL
{
    public class PostgreSQLConnector : IDatabaseConnector
    {
        public void Connect()
        {
            Console.WriteLine("Created PostgreSQL Connection !");

        }
    }
}
