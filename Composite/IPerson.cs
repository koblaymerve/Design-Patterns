﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface IPerson
    {
        string Name { get; set; }
        int Salary { get; set; }
        int GetCost();
    }
}
