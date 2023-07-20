
Console.WriteLine("Email kiriting");
var str = Console.ReadLine();

int a = 0;
int b = 0;

foreach (char s in str)
{
    if ((!char.IsLetterOrDigit(s)) && (s == '@' || s == '.'))
    {
        b = 1;
    }
    else if (char.IsDigit(s) || char.IsLetter(s))
    {
        b = 1;
    }
    else
    {
        Console.WriteLine($"{s} is an error");
        a = 1;
    }
}

if (a == 0 && str.Any(char.IsLower) != false)
{
    var lowercase = str.ToLower();

    Console.WriteLine($"Shu versiyasi yaxshiroq {lowercase}");

    Console.WriteLine(lowercase);

}