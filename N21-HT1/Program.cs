using N21_HT1;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomList<int> myList = new CustomList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.AddRange(new int[] { 30, 40, 50 });
        Console.WriteLine(myList.Contains(20));


        int[] array = new int[myList.count];
        myList.CopyTo(array);
        Console.WriteLine(string.Join(", ", array));


        int index = myList.IndexOf(30);
        Console.WriteLine(index);

        myList.Insert(1, 15);
        Console.WriteLine(string.Join(", ", myList.ToArray()));

        myList.Remove(30);
        Console.WriteLine(string.Join(", ", myList.ToArray()));

        myList.RemoveAt(2);
        Console.WriteLine(string.Join(", ", myList.ToArray()));
    }
}