using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    public class Book: IProduct
    {
        public double Price { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
