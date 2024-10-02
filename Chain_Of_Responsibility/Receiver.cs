using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Chain_Of_Responsibility
{
    class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }

        public Receiver(bool canDoBankTransfer, bool canDoMoneyTransfer, bool canDoPayPalTransfer)
        {
            BankTransfer = canDoBankTransfer;
            MoneyTransfer = canDoMoneyTransfer;
            PayPalTransfer = canDoPayPalTransfer;
        }
    }
}
