using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class CustomerManager
    {
        //Nesne oluşturma işni tek bir sınıf içerisinde yaptık ve bir üst sınıfta daha sade bir şekilde çağırıp kulandık.
        // Facade tasarım deseninin amacı daha az karmaşık bir üst sınıf oluşturmaktır.
        private CrossCuttingCorcernsFacede CrossCuttingCorcernsFacede;

        public CustomerManager()
        {
            CrossCuttingCorcernsFacede = new CrossCuttingCorcernsFacede();
        }

        public void Save()
        {
            CrossCuttingCorcernsFacede.Authorize.CheckUser();
            CrossCuttingCorcernsFacede.Caching.Cache();
            CrossCuttingCorcernsFacede.Logger.Log();
            Console.WriteLine("Saved");
        }
    }


    class CrossCuttingCorcernsFacede
    {
        public ILogger Logger;
        public ICaching Caching;
        public IAuthorize Authorize;

        public CrossCuttingCorcernsFacede()
        {
            Logger = new Logger();
            Caching = new Caching();
            Authorize = new Authorize();
        }
    }
}
