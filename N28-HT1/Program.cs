


using N28_HT1;

EventStack<Event> eventStack = new EventStack<Event>()
{
    new Event("nimadur", DateTime.Now),
    new Event("nima", DateTime.Now.AddHours(1)),
    new Event("dur", DateTime.Now.AddHours(2)),
    new Event("konstitutsiya", DateTime.Now.AddHours(3)),
    new Event("nidur", DateTime.Now.AddHours(11)),
};
//Event eventStack1 = new Event("nimadur", DateTime.Now);
//Event eventStack2 = new Event("nima", DateTime.Now.AddHours(1));
//Event eventStack4 = new Event("dur", DateTime.Now.AddHours(2));
//Event eventStack5 = new Event("konstitutsiya", DateTime.Now.AddHours(3));
//Event eventStack3 = new Event("nidur", DateTime.Now.AddHours(11));

Event eventt = new Event("ldskfj", new DateTime(2024, 01, 3));
eventStack.Push(eventt);

Event ev = eventStack.Peek();
Console.WriteLine($"Event: {ev.Name}, Date: {ev.Date}");
//eventStack.Push(eventStack1);
//eventStack.Push(eventStack2);
//eventStack.Push(eventStack3);
//eventStack.Push(eventStack4);
//eventStack.Push(eventStack5);

//while (eventStack.Count > 0) 
//{
//    Event ev = eventStack.Pop();
//    Console.WriteLine($"Event: {ev.Name}, Date: {ev.Date}");
//}

for (int i = 0; i < eventStack.Count; i++)
{
    Event evf = eventStack.Pop();
    Console.WriteLine($"Event: {evf.Name}, Date: {evf.Date}");
}




