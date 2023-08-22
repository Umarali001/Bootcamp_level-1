using N23_HT1;


var products = new List<Product>
{
    new Product("iPhone 12", 4, 60 ),
    new Product("Samsung Galaxy S21", 4, 75),
    new Product("Google Pixel 5", 4, 50),
    new Product("OnePlus 9 Pro", 4, 60),
    new Product("Xiaomi Mi 11", 4, 80),
    new Product("Sony Xperia 1 III", 3, 40),
    new Product("LG Wing", 3, 30),
    new Product("Motorola Edge+", 3, 35),
    new Product("Iphone 14", 5, 10),
    new Product("Asus ROG Phone 5", 4, 70)
};
var sds = products.OrderByDescending(x => x.Stars).ThenByDescending(x => x.Inventory).ToList();
// Print the top 5 products based on inventory
for (int i = 0; i < 5 && i < products.Count; i++)
{
    Console.WriteLine($"{products[i].Name} - {products[i].Inventory} in stock");
}
