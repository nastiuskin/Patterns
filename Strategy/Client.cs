using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Strategy
{
    public class Client
    {
        public static void main(string[] args)
        {
            string username = "Nastya";
            string password = "NASTYA";

            var passwordStrategy = new PasswordAuthenticationStrategy(username, password);
            var context = new AuthenticationContext(passwordStrategy);
            context.AuthenticateUser();

            var smsStrategy = new SMSAuthentication(username);
            context = new AuthenticationContext(smsStrategy);
            context.AuthenticateUser();
        }
    }
}
