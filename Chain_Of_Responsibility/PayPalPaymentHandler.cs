using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Chain_Of_Responsibility
{
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("PayPal payment completed");
            else if (NextHandler != null)
                NextHandler.Handle(receiver);
        }
    }
}
