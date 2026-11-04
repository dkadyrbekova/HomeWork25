using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
       
        List<int> numbers = new()
        {
            5, 12, 7, 20, 3, 15, 30, 8, 25
        };

        List<int> bigNumbers = numbers.Filter(n => n > 10);
        List<string> numberTexts = bigNumbers.Transform(n => $"Number: {n}");

        Console.WriteLine("Числа больше 10:");
        ListExtensions.ForEach(numberTexts, s => Console.WriteLine(s));
        Console.WriteLine();

       
        List<Product> products = new()
        {
            new Product(1, "Laptop", 85000, "Electronics"),
            new Product(2, "Mouse", 800, "Electronics"),
            new Product(3, "Phone", 45000, "Electronics"),
            new Product(4, "Book", 600, "Books"),
            new Product(5, "Headphones", 4500, "Electronics"),
            new Product(6, "Desk", 12000, "Furniture"),
            new Product(7, "Monitor", 18000, "Electronics")
        };

        List<Product> expensive = products.Filter(p => p.Price > 1000);
        List<string> expensiveNames = expensive.Transform(p => p.Name);

        Console.WriteLine("Товары дороже 1000:");
        ListExtensions.ForEach(expensiveNames, name => Console.WriteLine(name));
        Console.WriteLine();

       
        List<string> report = products
            .Filter(p => p.Category == "Electronics")
            .Filter(p => p.Price > 5000)
            .Transform(p => $"{p.Name} - {p.Price}");

        Console.WriteLine("Electronics дороже 5000:");
        ListExtensions.ForEach(report, line => Console.WriteLine(line));
    }
}