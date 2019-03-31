using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proxy
{
    class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 10; i++)
            {
                result += i * result;
                Thread.Sleep(500);
            }
            return result;
        }
    }
}
