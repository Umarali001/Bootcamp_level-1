
using System.Collections.Immutable;

string[] student = new string[5];
student[0] = "Tom";
student[1] = "John";
student[2] = "Simon";
student[3] = "Jesika";
student[4] = "Anton";


int[] ball = new int[5];
ball[0] = 20;
ball[1] = 81;
ball[2] = 90;
ball[3] = 95;
ball[4] = 54;


int a = 0;
int b = 0;
int c = 0;

string ab = default;
string bc = default;
string cd = default;


for (int i = 0;i < ball.Length; i++)
{ 
    if (ball[i] > 90)
    {
        a += 1;
        ab += $"90 dan tepa : {student[i]}\n";
    }
    else if (ball[i] > 80 && ball[i] <= 90)
    {
        b += 1;
        bc += $"80 dan tepa : {student[i]}\n";

    }
    else if (ball[i] <= 70)
    {
        c += 1;
        cd += $"70 dan past : {student[i]}\n";

    }
}




for (int i = 0; i < ball.Length; i++)
{
    Array.Sort(ball);
    if (i == 0)
    {
        Console.WriteLine($"Eng kam ball : {ball[i]}");
    }
    else if (i == ball.Length / 2)
    {
        Console.WriteLine($"O'rtacha ball : {ball[i]}");
    }
    else if (ball.Length - 1 == i)
    {
        Console.WriteLine($"Yuqori ball : {ball[i]}");
    }
}

Console.WriteLine($" 90 dan baland olgan studentlar soni : {a}");
Console.WriteLine($" 80 dan baland olgan studentlar soni : {b}");
Console.WriteLine($" 70 dan past olgan studentlar soni : {c}");


Console.WriteLine(ab);
Console.WriteLine(bc);
Console.WriteLine(cd);

