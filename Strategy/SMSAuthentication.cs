using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Strategy
{
    public class SMSAuthentication: IAuthenticationStrategy
    {
        private readonly string _username;
        
        public SMSAuthentication(string username)
        {
            this._username = username;
        }
        public bool Authenticate()
        {
            Console.WriteLine($"Authenticating {_username} using SMS code");
            return true;
        }
    }
}
