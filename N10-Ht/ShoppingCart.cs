using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N10_Ht
{
    internal class ShoppingCart
    {
        private Dictionary<Product,int> items = new Dictionary<Product, int>();

        public void Add(Product product, int count)
        {
            foreach (var item in items)
            {
                if (item.Key.Name == product.Name)
                {
                    items[item.Key] += count;
                    return;
                }
            }
            items.Add(product, count);

         
        }

        public bool Buy(Product product, int count) 
        {
            foreach (var item in items)
            {
                if (item.Key.Name == product.Name)
                {
                    if (items[item.Key] >= count)
                    {
                        items[item.Key] -= count;
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Bizda bu mahsulot yetarli emas");
                    }
                    
                }
            }
            Console.WriteLine("Bunday mahsulot yetarli emas");

            return false;
        }
        public void Display()
        {
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key.Name} {item.Value}");
            }
        }
    }
}
