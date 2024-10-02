using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Template_method
{
    public class Client
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Making coffee:");
            Beverage coffee = new Coffee();
            coffee.Prepare();

            Console.WriteLine();

            Console.WriteLine("Making tea:");
            Beverage tea = new Tea();
            tea.Prepare();
        }
    }
}
