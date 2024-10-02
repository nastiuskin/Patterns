﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Template_method
{
    public class Tea: Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
