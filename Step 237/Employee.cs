﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Step_237
{
    public class Employee: Person
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
