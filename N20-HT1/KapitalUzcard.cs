using N20_HT1;

internal class KapitalUzcard : IDebitCard
{
    public string CardNumber { get; set; }
    public string BankName { get; init; }
    public decimal Balance { get; set; }


    public KapitalUzcard(string cardNumber, string bankName, decimal balance)
    {
        CardNumber = cardNumber;
        BankName = bankName;
        Balance = balance;
    }
}