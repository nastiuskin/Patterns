using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Template_method
{
    public class Coffee: Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee grounds");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

    }
}
