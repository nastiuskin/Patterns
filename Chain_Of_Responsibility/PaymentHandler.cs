using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Chain_Of_Responsibility
{
    internal abstract class PaymentHandler
    {
        public PaymentHandler NextHandler { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
