using System;

namespace FactoryMethod.PaymentFactory
{
    public class CreditCart : IPay
    {
        public bool Pay()
        {
            return this.MakeCreditCartPay();
        }

        private bool MakeCreditCartPay()
        {
            Console.WriteLine("pay with credit cart");
            return true;
        }
    }
}
