using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11_HT1
{
    internal class ToDoList
    {
        private List<ToDo> list = new List<ToDo>();


        public void MarkDone(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list[index].IsCompleted = true;
                Console.WriteLine($"{list[index].TaskName} {list[index].IsCompleted}");
            }
        }


        public void Add(string tasks)
        {
            list.Add(new ToDo { TaskName = tasks, IsCompleted = false });
            foreach (ToDo toDo in list)
            {
                if (toDo.TaskName == tasks)
                {
                    Console.WriteLine("qushildi");
                }
                else { Console.WriteLine("qushilmadi"); }

            }
        }



        public void Display()
        {
           for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} {list[i].TaskName} {list[i].IsCompleted}");

            }

        }

    }
}
