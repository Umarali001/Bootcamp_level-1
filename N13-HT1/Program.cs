
using System.ComponentModel;
using System.Drawing;

Animals animals = new Animals();
animals.MakeSound();

Bird bird = new Bird();
bird.Fly();

Mammal mammal = new Mammal();
mammal.Run();

Fish Fish = new Fish();
Fish.Swim();

Sparrow Sparrow = new Sparrow();
Sparrow.Speed();

Tiger Tiger = new Tiger();
Tiger.Run();

GreatWhiteShark greatWhiteShark = new GreatWhiteShark();
greatWhiteShark.TallLength();


public class Animals
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}


public class Bird : Animals
{
       public void Fly()
    {
        Console.WriteLine("Fly");
    }
}


public class Mammal : Animals
{
    public void Run()
    {
        Console.WriteLine("Run");
    }
}


public class Fish : Animals
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}


public class Sparrow : Bird
{
    public  void Speed()
    { Console.WriteLine("Sparrows usually fly at the speed of 24 miles per hour"); }
}


public class Tiger : Mammal
{
    public void Types()
    {
        Console.WriteLine("8 There are six different types of tigers.");
    }
}


public class GreatWhiteShark : Fish
{
    public void TallLength()
    {
        Console.WriteLine("Adult great white sharks grow to a maximum size of approximately 20 feet in length");
    }
}

