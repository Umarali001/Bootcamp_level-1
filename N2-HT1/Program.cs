Console.WriteLine("Ismingizni kiriting");
string name = Console.ReadLine();
Console.WriteLine("SHarifingizni kiriting");
string patronymic = Console.ReadLine();
Console.WriteLine("Yoshingizni kiriting");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sizning ismingiz {name}\nSharifingiz {patronymic}\nyoshingiz {age}");