using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Template_method
{
    public abstract class Beverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

    }
}
