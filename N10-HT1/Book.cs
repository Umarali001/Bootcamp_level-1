using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N10_HT1
{
    internal class Book
    {
        public int Id;
        public string Title;    // sarlavha
        public int Num;  // boshqa

        public Book(int id, string title, int num)
        {
            Id = id;
            Title = title;
            Num = num;
        }


    }
}
