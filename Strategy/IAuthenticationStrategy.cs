using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Strategy
{
    public interface IAuthenticationStrategy
    {
        bool Authenticate();
    }
}
