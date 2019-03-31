using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Customer : Person
    {
        public string City { get; set; }

        //Customer nesnesini klonlamak için
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
