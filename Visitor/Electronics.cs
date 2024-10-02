using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    public class Electronics : IProduct
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        public double Price { get; set; }

    }
}
