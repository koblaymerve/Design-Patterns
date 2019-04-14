using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class PersonalCar : CarBase
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override int HirePrice { get; set; }
    }
}
