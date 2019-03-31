using System;

namespace Prototype
{
    // GOAL : Nesne oluşma maaliyetlerini azaltmak

    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { FirstName = "Joe", LastName = "Doe", City = "Space" };

            Customer customer2 = (Customer)customer.Clone();
            customer2.FirstName = "Merlin";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
