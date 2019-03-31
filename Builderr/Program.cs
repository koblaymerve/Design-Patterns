using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDirector productDirector = new ProductDirector();
            var builder = new NewCustomeProductBuilder();
            productDirector.GenerateProduct(builder);
            var model = builder.GetModel();

            Console.WriteLine("Hello World!");
        }
    }
}
