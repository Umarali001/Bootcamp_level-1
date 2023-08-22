using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal class PaymePaymentProvider : IPaymentProvider
    {
        public decimal TransferInterest { get; init; }  // foiz

        public PaymePaymentProvider(decimal transferInterest)
        {
            TransferInterest = transferInterest;
        }

        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
        {
            decimal total = amount + amount * TransferInterest;
        }
    }
}
