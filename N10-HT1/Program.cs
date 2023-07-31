// Kitob tipini yaratish
class Book
{
    // fieldlar
    public int Id { get; set; }
    public string Title { get; set; }
    public string Another { get; set; }
}


// Kutubxona boshqaruvi uchun tip yaratish
class LibraryManagement
{
    public Dictionary<int, int> Books = new Dictionary<int, int>();
}














    static void Main()
    {
        // Kitoblar yaratish
        Book book1 = new Book { Id = 1, Title = "Kitob 1", Another = "a" };
        Book book2 = new Book { Id = 1, Title = "Kitob 2", Another = "b" };
        Book book3 = new Book { Id = 1, Title = "Kitob 3", Another = "c" };
    }