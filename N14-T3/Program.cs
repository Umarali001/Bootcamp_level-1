
using System;
using System.Collections.Generic;

public class NotificationMessages
{
    private Dictionary<string, string> messages = new Dictionary<string, string>();

    public void AddMessage(string name, string content)
    {
        messages[name] = content;
    }

    protected KeyValuePair<string, string> FindMessage(string name)
    {
        if (messages.ContainsKey(name))
        {
            return new KeyValuePair<string, string>(name, messages[name]);
        }
        else
        {
            return default;
        }
    }

    public void SearchMessage(string name)
    {
        var messagePair = FindMessage(name);
        if (messagePair.Equals(default(KeyValuePair<string, string>)))
        {
            Console.WriteLine("Message not found.");
        }
        else
        {
            Console.WriteLine($"{messagePair.Key} - {messagePair.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        NotificationMessages notification = new NotificationMessages();
        notification.AddMessage("SuccRegistration", "You successfully registered");
        notification.AddMessage("AskPassword", "Enter your password");
        notification.AddMessage("Blocked", "Your account has been blocked");

        Console.WriteLine("Enter a message name to search:");
        var input = Console.ReadLine();
        notification.SearchMessage(input);
    }
}
