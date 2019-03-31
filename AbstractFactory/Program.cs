using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory());
            productManager.GetAll();
            Console.ReadLine();
        }
    }
}
