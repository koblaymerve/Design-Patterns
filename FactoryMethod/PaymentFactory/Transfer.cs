using System;

namespace FactoryMethod.PaymentFactory
{
    public class Transfer : IPay
    {
        public bool Pay()
        {
            return this.CheckTransfer();
        }

        public bool CheckTransfer()
        {
            Console.WriteLine("checkted transfer");
            return true;
        }
    }
}
