using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1;

internal class MillyHumo : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public decimal Balance { get; set; }    

    public MillyHumo(string cardNumber, string bankName, decimal balance)
    {
        CardNumber = cardNumber;
        BankName = bankName;
        Balance = balance;
    }
}
