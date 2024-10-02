using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    public interface IVisitor
    {
        public void Visit(Electronics electronics);
        public void Visit(Clothes clothes);
        public void Visit(Book book);
    }
}
