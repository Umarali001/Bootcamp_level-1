
DateTime[] daay = new DateTime[5];
daay[0] = new DateTime(2023, 7, 15);
daay[1] = new DateTime(2023, 7, 16);
daay[1] = new DateTime(2023, 7, 17);
daay[1] = new DateTime(2023, 7, 18);
daay[1] = new DateTime(2023, 7, 19);


float[] sleep =  new float[5] {7f,8f,6f,9f,10f};
float[] disor = new float[5] {0f,2f,0f,2f,1f};

float s = 0;
float b = 0;
for(int i=0; i < sleep.Length; i++ )
{
    if (i == 0)
    {
       s = (sleep[0] - disor[0]) / (8 + 0) * 10;
        Console.WriteLine($"{daay[0]}-{sleep[0]} hours {s} score");
    }
    else if (i > 0)
    {
       b = 8 - sleep[i-1];
        if (b>= 0)
        {
            s = (sleep[0] - disor[0]) / (8 + b) * 10;
            Console.WriteLine($"{daay[i]}-{sleep[i]} hours {s} score");
        }
        else
        {
            s = (sleep[0] - disor[0]) / (8 + 0) * 10;
            Console.WriteLine($"{daay[i]}-{sleep[i]} hours {s} score");
        }
    }
}