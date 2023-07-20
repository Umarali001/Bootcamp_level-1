

string[] names = new string[5] { "int qaysi type turiga kiradi?", "ram xotira nechchiga bulinadi?", "belgilar bilan qaysi value ishlaydi?", "else-if ga muqobile qaysi?", "string uzunligini qaysi metod aniqlaydi?" };
string[] correct = new string[5] { "primitive", "2", "char", "switch case", "Length" };
string[] incorrect = new string[5] { "Complex", "1", "bool", "while", "len" };

int a = 0;
int b = 0;
string[] aaa = new string[5];
string[] bbb = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(names[i]);
    Console.WriteLine($"A: {correct[i]}");
    Console.WriteLine($"B {incorrect[i]}");
    var natija = Console.ReadLine();
    if (natija == "A")
    {
        a += 1;
    }
    else if (natija == "B")
    {
        aaa[b] = names[i];
        bbb[b] = correct[i];
        b += 1;
    }
}
Console.WriteLine($"To'g'ri javoblar soni: {a} ta");
if (aaa.Length != 0)
{
    Console.WriteLine($"Noto'g'ri javoblar:{b} ta va qaysiligini kurishingiz mumkun");

    for (int i = 0; i < b; i++)
    {
        Console.WriteLine(aaa[i]);
        Console.WriteLine($"{bbb[i]}\n");

    }
}
else
{
    Console.WriteLine("Noto'g'ri javoblar: 0 ta");

}