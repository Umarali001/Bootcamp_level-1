using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal class UzumPaymentProvider : IPaymentProvider
    {
        public decimal TransferInterest { get; init; }  // foiz

        public UzumPaymentProvider(decimal transferInterest)
        {
            TransferInterest = transferInterest;
            
        }

        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, int amount)
        {
            decimal total = amount + amount * TransferInterest;

            if (sourceCard.Balance <= total)
            {

            }
        }
    }
}
