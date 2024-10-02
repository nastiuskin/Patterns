using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Chain_Of_Responsibility
{
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
                Console.WriteLine("Money payment completed");
            else if (NextHandler != null)
                NextHandler.Handle(receiver);
        }
    }
}
