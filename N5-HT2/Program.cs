Console.Write("son kiriting: ");
int son1 = Convert.ToInt32(Console.ReadLine());



while (true)
{
    Console.Write("  * - + yoki e belgilaridan birini kiriting: ");
    // char val = Convert.ToChar(Console.ReadLine());
    var val = Console.ReadLine();
    int son3 = 0;
    if (val == "e")
    {
        break;
    }
    else
    {
        Console.Write("son kiriting: ");
        int son2 = Convert.ToInt32(Console.ReadLine());

        if (val == "*")
        {
            son3 = son1 * son2;
        }
        else if (val == "-")
        {
            son3 = son1 - son2;
        }
        else if (val == "+")
        {
            son3 = son1 + son2;
        }


        else
        {
            Console.WriteLine("Noto'g'ri belgi kiritildi. Qayta urining.");
            break;
        }

        Console.WriteLine(son3);
        break;
    }

}