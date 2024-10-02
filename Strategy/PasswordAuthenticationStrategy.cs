using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Strategy
{
    public class PasswordAuthenticationStrategy: IAuthenticationStrategy
    {
        private readonly string _username;
        private readonly string _password;
        public PasswordAuthenticationStrategy(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public bool Authenticate()
        {
            Console.WriteLine($"Authentication {_username} using password {_password}");
            return true;
        }
    }
}
