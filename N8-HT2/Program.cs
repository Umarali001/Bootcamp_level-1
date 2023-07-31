


using System;
using System.Net.Sockets;
using System.Reflection;

var list = new List<string>();

list.Add("Jeck");
list.Add("Sardor");
list.Add("John");
list.Add("Ali");



var CompanyName = "The Travel Guru";
var NameToken = "{{Name}}";
var CompanyNameToken = "{{CompanyName}}";
var TicketDateToken = "{{TicketDate}}";



var dictionary = new Dictionary<string, string>();

dictionary.Add("Underage", "Uzur hurmatli {{Name}} siz liyihadan foydalanish uchun kichiksiz");
dictionary.Add("GoldenAger", "Uzr,hurmatli {{Name}} loyiha yoshlar uchun mo'ljallangan");



var datetime = new Dictionary<DateTime, int>();

datetime.Add(new DateTime(2023, 7, 18, 20, 18, 00),5) ;
datetime.Add( new DateTime(2023, 7, 18, 8, 20, 18),2);
datetime.Add(new DateTime(2023,7, 18, 9, 15,8),0);


var linkedLit = new LinkedList<string>();

linkedLit.AddLast("Hello {{Name}}. Welcome to onboard.{{CompanyName}} Team.");
linkedLit.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team.");
linkedLit.AddLast("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");


int b = 0;

Start:

Console.WriteLine("Ismingizni kiriting");
var name = Console.ReadLine();

for (int i = 0; i < name.Length; i++)
{
    if (char.IsDigit(name[i]))
    {
        Console.WriteLine("Invalid name");
        goto Start;
    }
    else if (!char.IsDigit(name[i]) && i==name.Length-1)
    {
        list.Append(name);

        Console.WriteLine("yoshingizni kiriting");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            Console.WriteLine(dictionary["Underage"].Replace(NameToken, name));
        }
        else if (age > 90)
        {
            Console.WriteLine(dictionary["GoldenAger"].Replace(NameToken, name));
        }
        else
        {
            list.Add(name);
            break;

        }
    }

}
DateTime dat = default;
 DateTime dateTime = DateTime.Now;


foreach (KeyValuePair<DateTime, int> lln in datetime)
{

    if (list.Count <= lln.Value)
    {
        dat = lln.Key;
        
    }

 };

string message = default;

for (var index = 0; index < list.Count; index++)
{
    if (index == 0)
    {
        
        message = linkedLit.ElementAt(0).Replace(NameToken, list[index]);
        message += linkedLit.ElementAt(1).Replace(CompanyNameToken, CompanyName);
        message += message.ElementAt(2).Replace(TicketDateToken, dat.ToString(), CompanyNameToken, CompanyName);
       
        
        // shu qismini tug'irlay olmadim
    }
    Console.WriteLine(message);
}
    




