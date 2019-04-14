using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new PersonalCar { HirePrice = 2500, Make = "BMW", Model = "3.20" };
            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;
            Console.WriteLine($"Concreate : {personalCar.HirePrice}");

            Console.WriteLine($"Special Offer : {specialOffer.HirePrice}");

            Console.ReadLine();
        }
    }
}


