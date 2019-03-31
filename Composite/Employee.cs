using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> people = new List<IPerson>();
        public string Name { get; set; }
        public int Salary { get; set; }

        public void AddSubOrdinate(IPerson person)
        {
            people.Add(person);
        }

        public void RemoveSubOrdinate(IPerson person)
        {
            people.Remove(person);
        }

        public IPerson GetPerson(int index)
        {
            return people[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var person in people)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetCost()
        {
            int result = 0;
            foreach (var person in people)
            {
                result += person.Salary;
            }
            return result;
        }
    }
}
