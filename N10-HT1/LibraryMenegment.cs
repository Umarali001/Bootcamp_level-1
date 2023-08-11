using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace N10_HT1
{
    internal class LibraryMenegment
    {
        //Dictionary<Book,int> books = new Dictionary<Book,int>();
        List<Book> books = new List<Book>();


        public void Add(Book book)
        {
            books.Add(book);
        }


        public bool Chekcout(int BookId)
        {
            foreach (var book in books)
            {
                if (book.Id == BookId && BookId > 0)
                {
                    book.Num -= 1;
                    Console.WriteLine($"Kitob nomi: {book.Title} Kitob soni: {book.Num}");

                    return true;
                }
            }
            return false;
        }

    }
}
      


