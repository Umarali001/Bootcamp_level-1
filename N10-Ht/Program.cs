

using N10_Ht;
using System.Linq.Expressions;

Product product = new Product("olma", 10_000);
Product product1 = new Product("Behi", 13_000);
Product product2 = new Product("olma", 5_000);
Product product3 = new Product("Behi", 10_200);
Product product4 = new Product("olma", 6_800);
Product product5 = new Product("Behi", 12_200);


ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.Add(product, 800);
shoppingCart.Add(product1, 300);
shoppingCart.Add(product2,100);
shoppingCart.Add(product3, 10);
shoppingCart.Add(product4, 800);
shoppingCart.Add(product5,20);
shoppingCart.Buy(product, 1600);

shoppingCart.Display();
