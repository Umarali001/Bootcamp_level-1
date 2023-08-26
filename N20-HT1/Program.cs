

using N20_HT1;

IDebitCard humo = new MillyHumo("3433_4242_5646_2343_3425", "IpakYuli",32445);

IDebitCard uzcard = new KapitalUzcard("6758_4252_5346_2343_3435", "Capitalbank", 67565);



IPaymentProvider paymePaymentProvider = new PaymePaymentProvider(0.01M);

IPaymentProvider uzumPaymentProvider = new UzumPaymentProvider(0.02M);




OnlineMarket onlineMarketWithPayme = new OnlineMarket(paymePaymentProvider);
OnlineMarket onlineMarketWithUzum = new OnlineMarket(uzumPaymentProvider);




Product laptop = new Product("Laptop", 800);
Product phone = new Product("Phone", 400);


onlineMarketWithPayme.Add(laptop);
onlineMarketWithPayme.Add(phone);
onlineMarketWithUzum.Add(laptop);
onlineMarketWithUzum.Add(phone);


onlineMarketWithPayme.Buy("Laptop", 1, uzcard);
onlineMarketWithPayme.Buy("Phone", 2, humo);

onlineMarketWithUzum.Buy("Laptop", 1, uzcard);
onlineMarketWithUzum.Buy("Phone", 1, humo);

// Displaying remaining balances
Console.WriteLine(uzcard.Balance);
Console.WriteLine(humo.Balance);