using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal interface IPaymentProvider
    {
        public decimal TransferInterest { get; init; }  // foiz


        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
        {
            // bir kartadan boshqa kartaga utkazadi
        }
    }
}
