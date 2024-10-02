using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    public interface IProduct
    {
       public void Accept(IVisitor visitor);
    }
}
