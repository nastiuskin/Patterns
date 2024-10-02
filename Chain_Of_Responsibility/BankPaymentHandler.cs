using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Chain_Of_Responsibility
{
    class BankPaymentHandler : PaymentHandler
    {   
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
                Console.WriteLine("Bank payment completed");
            else if (NextHandler != null)
                NextHandler.Handle(receiver);
        }
    }
}
