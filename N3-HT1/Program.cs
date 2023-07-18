
Console.WriteLine("sonlar kiritilsinmi y or n");
bool number = Console.ReadLine() == "y";

Console.WriteLine("harflar kiritilsinmi y or n");
bool litter = Console.ReadLine() == "y";

Console.WriteLine("symbollar kiritilsinmi y or n");
bool symbol = Console.ReadLine() == "y";

Console.WriteLine("kodni uzunligini kiriting");
int longe = Convert.ToInt32(Console.ReadLine());

for (int j = 0; j < longe; j++)
{
    Random random = new Random();
    int num = random.Next(0, 3);
    /*
    switch (num)
    {
        case 0:Console.Write((char)random.Next(48, 58)); break;
        case 1:Console.Write((char)random.Next(65, 91)); break;
               Console.Write((char)random.Next(97, 123)); break;
        case 2:Console.Write((char)random.Next(33, 48)); break;
        default:j-- ; break;

    }


    */


    if (num == 0 && number == true)
    {
        Console.Write((char)random.Next(48, 58));
    }
    else if (num == 1 && litter == true)
    {
        int rrr = random.Next(0, 3);
        if (rrr == 0)
        {
            Console.Write((char)random.Next(65, 91));
        }
        else
        {
            Console.Write((char)random.Next(97, 123));
        }
    }
    else if (num == 2 && symbol == true)
    {
        Console.Write((char)random.Next(33, 48)); ;
    }
    else
    {
        j--;
    }
}

