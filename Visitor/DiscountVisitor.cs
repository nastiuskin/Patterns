using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    public class DiscountVisitor : IVisitor
    {
        public void Visit(Electronics electronics)
        {
            electronics.Price *= 0.7;
        }

        public void Visit(Clothes clothes)
        {
            clothes.Price *= 0.8;
        }

        public void Visit(Book book)
        {
            book.Price *= 0.9;
        }
    }
}
