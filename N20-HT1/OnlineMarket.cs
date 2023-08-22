using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        private List<Product> _products = new List<Product>();

        public OnlineMarket(IPaymentProvider provider)
        {
             _provider = provider;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }


        public void Buy(string name, int number, IDebitCard card)
        {
            Product product = _products.Find(x => x.Name == name);
            if (product != null)
            {
                decimal totalamount = product.Price * number;
                _provider
            }
        }
    }
}
