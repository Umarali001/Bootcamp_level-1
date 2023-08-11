
using N10_HT1;

Book book1 = new Book(1,"Amir Temur", 5 );
Book book2 = new Book(2, "Samo", 2);
Book book3 = new Book(3, "Sariq Dev", 1);


LibraryMenegment libraryMenegment = new LibraryMenegment();

libraryMenegment.Add(book1);
libraryMenegment.Add(book2);
libraryMenegment.Add(book3);

Console.WriteLine("kitob Id sini kiriting");
int bookId = Convert.ToInt32(Console.ReadLine());
//libraryMenegment.Chekcout(bookId);

if (libraryMenegment.Chekcout(bookId))
{
    Console.WriteLine("kitob topildi");
}
else
    Console.WriteLine("kitob topilmadi");
