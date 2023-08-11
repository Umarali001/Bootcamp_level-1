

using N11_HT1;
using System.Timers;

ToDoList toDoList = new ToDoList();
toDoList.Add("Planning for today");
toDoList.Add("Cooking");
toDoList.Add("Doing homework");

Console.WriteLine(" Choose a command: display all - d / mark done - m / add - a");
var tess = Console.ReadLine();


switch (tess)
{
    case "d":
        {
            toDoList.Display();
            break;

        }

    case "m":
        {
            toDoList.Display();
            Console.WriteLine("raqamini kiriting");
            int index = int.Parse(Console.ReadLine()) - 1;
            toDoList.MarkDone(index);   
            break;
        }

    case "a":
        {
            Console.WriteLine("Vazifa kiriting");
             string tasks = Console.ReadLine();
            toDoList.Add(tasks);
            break;
        }
}