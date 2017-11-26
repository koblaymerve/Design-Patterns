using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton
{
    class CustomerManager
    {
        static CustomerManager _customerManager;
        static Object _locker = new Object();
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            /*MultiThread yapısına uygun olması için _customerManager nesnesinin oluşturulması sırasında kilitliyoruz*/
           if (_customerManager == null)
            {
                lock (_locker)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;

            /*return _customerManager ?? (_customerManager = new CustomerManager()); //null olup olmadığına bak null değilse _customerManageri döndür, null ise yeni oluştur ve onu döndür.*/

        }

        public void Save()
        {
            Console.WriteLine("Saved!!");
        }
    }
}
