using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    public class TotalPriceVisitor: IVisitor
    {
        public double totalPrice = 0;
        public void Visit(Electronics electronics)
        {
            totalPrice += electronics.Price;
        }
        public void Visit(Clothes clothes)
        {
            totalPrice += clothes.Price;
        }

        public void Visit(Book book)
        {
            totalPrice += book.Price;
        }
    }
}
