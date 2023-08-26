using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT1
{
    internal class TubNumber
    {
        private List<int> _numbers = new List< int>();


        public void Add(List<int> number)
        {
            foreach (var num in number)
            {
                bool isPrime =Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(x => num % x != 0);
                if (isPrime && num != 1)
                {
                    _numbers.Add(num);
                }

            }

            _numbers.Reverse();
        }

        public void Gets(List<int> number)
        {
            Add(number);

            foreach (var num in _numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
