
Animals animals = new Animals();
animals.MakeSound();

Bird bird = new Bird();
bird.Fly();

Mammal mammal = new Mammal();
mammal.Run();

Fish Fish = new Fish();
Fish.Swim();




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

}


public class Tiger : Mammal
{
     
}


public class GreatWhiteShark : Fish
{

}

