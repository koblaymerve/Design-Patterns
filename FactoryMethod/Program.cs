using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    partial class Program
    {
        /**/
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory2());
            DatabaseFactory.DatabaseFactory databaseFactory = new DatabaseFactory.DatabaseFactory();
            databaseFactory.CreateDatabaseConnector().Connect();
            customerManager.Save();
            Console.ReadLine();
        }
    }
}
