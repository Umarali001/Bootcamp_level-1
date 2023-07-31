using System.Text.RegularExpressions;
/*
Console.WriteLine("Ismingizni kiriting");
var name = Console.ReadLine();

for (int i = 0; i < name.Length; i++)
{
    if (char.IsDigit(name[i]))
    {
         onsole.WriteLine(name);
    }
}

*/



List<string> list = new List<string>()
{
     "john.doe@example.com",
     "jane.smith123@example.net",
     "user@domain",
     "invalid.email",
     "another@example"
};


var pattern = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");

foreach (var item in list)
{
    Console.WriteLine(pattern.IsMatch(item));
}
