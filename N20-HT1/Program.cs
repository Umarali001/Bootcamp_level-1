

using N20_HT1;

IDebitCard humo = new MillyHumo("3433_4242_5646_2343_3425", "IpakYuli",32445);

IDebitCard uzcard = new KapitalUzcard("6758_4252_5346_2343_3435", "Capitalbank", 67565);



IPaymentProvider paymePaymentProvider = new PaymePaymentProvider(0.01M);

IPaymentProvider uzumPaymentProvider = new UzumPaymentProvider(0.02M);




OnlineMarket onlineMarketWithPayme = OnlineMarket(paymePaymentProvider);





Product laptop = new Product("Laptop", 800);
Product phone = new Product("Phone", 400);


