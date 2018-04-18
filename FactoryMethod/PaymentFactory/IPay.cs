using FactoryMethod.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.PaymentFactory
{
    public interface IPay
    {
        bool Pay();
    }
    public class PaymentFactory
    {
        public IPay CreatePayment(string paymentType)
        {
            if(paymentType == PaymentTypes.CreditCart)
            {
                return new CreditCart();
            }
            else if(paymentType == PaymentTypes.Transfer)
            {
                return new Transfer();
            }
            return new CreditCart();
        }
    }
}
