
string[] usernames = { "asad", "aliboy", "imro_nshox", "ser_dar", "themahkmudoff" };
string[] user = { "kosmonavt", "programmer", "clever" };

Console.Write("Ismingizni kiriting: ");
var ism = Console.ReadLine();
Console.Write("Familiyangizni kiriting: ");
var familiya = Console.ReadLine();

var username = ($"{ism}_{familiya}");
username = username.Trim();

Random rd = new Random();
int index = rd.Next(0, user.Length);
username += user[index];

while (true)
{
    if (usernames.Contains(username))
    {

        int a = rd.Next(1, 999);
        username = ($"{username}{a}");
    }
    else
    {
        Console.WriteLine(username);
        break;
    }
}



