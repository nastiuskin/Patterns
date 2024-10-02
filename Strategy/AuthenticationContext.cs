using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Strategy
{
    public class AuthenticationContext
    {
        private IAuthenticationStrategy _strategy;
        public AuthenticationContext(IAuthenticationStrategy strategy) 
        {
            this._strategy = strategy;
        }

        public bool AuthenticateUser()
        {
            return _strategy.Authenticate();
        }
    }
}
