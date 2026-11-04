using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<User> users = new()
        {
            new User(1, "Alex", 25, "alex@mail.com"),
            new User(2, "Bekzat", 17, "bekzat@mail.com"),
            new User(3, "Anna", 19, "anna@mail.com"),
            new User(4, "Dina", 22, "dina@mail.com"),
            new User(5, "Aibek", 18, "aibek@mail.com")
        };

        var filter = new UserFilter();
        var builder = new NotificationBuilder();
        var sender = new NotificationSender();

       
        List<User> adults = filter.GetAdults(users);
        Console.WriteLine("Совершеннолетние пользователи:");
        adults.ForEach(u => Console.WriteLine($"{u.Name}, {u.Age}"));
        Console.WriteLine();

        
        List<string> notifications = builder.Build(adults);
        Console.WriteLine("Уведомления:");
        sender.SendAll(notifications);
        Console.WriteLine();

        List<User> aUsers = filter.GetNamesStartingWithA(users);
        Console.WriteLine("Имена, начинающиеся на A:");
        aUsers.ForEach(u => Console.WriteLine(u.Name));
    }
}