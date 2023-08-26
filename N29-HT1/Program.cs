





class Programm
{
    static async Task Main(string[] args)
    {
        int result = await CalculateAsync();
        Console.WriteLine("Result: " + result);
    }

    static async Task<int> CalculateAsync()
    {
        await Task.Delay(10020);
        return 42;
    }
}