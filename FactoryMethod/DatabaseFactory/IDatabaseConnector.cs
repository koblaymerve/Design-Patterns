using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DatabaseFactory
{
    public interface IDatabaseConnector
    {
        void Connect();
    }
}
