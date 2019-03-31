using System;

namespace Proxy
{
    //Cachlemek ile aynı mantık. Bir datayı servisten bir kere al ve tekrar istendiğinde sorgu atmadan tuttğun nesneyi dön
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Design Pattern!");
            CreditBase creditManager = new CreditManagerProxy();

            Console.WriteLine($"{creditManager.Calculate()}");            
            Console.WriteLine($"{creditManager.Calculate()}");
            Console.ReadLine();
        }
    }
}
