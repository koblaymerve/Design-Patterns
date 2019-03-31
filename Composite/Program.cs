using System;

namespace Composite
{
    class Program
    {
        //Hiyerarşik nesne yapısı kurulmak istendiğinde kullanılan tasarım deseni. MEnüler ve menü itemları gibi bir örnek düşünebiliriz
        static void Main(string[] args)
        {
            Employee people1 = new Employee { Name = "Joe Doe",Salary = 150 };
            Employee people2 = new Employee { Name = "John Doe", Salary = 350 };

            people1.AddSubOrdinate(people2);

            Employee people3 = new Employee { Name = "Jonny Doe", Salary = 25 };
            people1.AddSubOrdinate(people3);

            Employee people4 = new Employee { Name = "Johanna Doe", Salary = 10 };
            people2.AddSubOrdinate(people4);

            Console.WriteLine($"{people1.Name}");
            foreach (IPerson person in people1)
            {
                Console.WriteLine($"    {person.Name} - {person.Salary}");
                foreach (IPerson item in (Employee)person)
                {
                    Console.WriteLine($"        {item.Name} - {item.Salary}");
                }
                Console.WriteLine($"    Cost for {person.Name} : {person.GetCost()}");
            }
            Console.WriteLine($"Cost for {people1.Name} : {people1.GetCost()}");
            Console.ReadLine();

        }
    }
}
