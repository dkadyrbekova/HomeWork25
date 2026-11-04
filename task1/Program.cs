using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new()
        {
            12, 5, 18, 3, 25, 8, 14, 7, 30, 11
        };

        var filter = new NumberFilter();
        var transformer = new NumberTransformer();
        var searcher = new NumberSearcher();
        var printer = new NumberPrinter();

        Console.WriteLine("Чётные числа:");
        List<int> evenNumbers = filter.GetEven(numbers);
        foreach (int n in evenNumbers)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Числа, умноженные на 2:");
        List<int> doubled = transformer.DoubleAll(numbers);
        foreach (int n in doubled)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Первое число больше 15: " + searcher.FindFirstGreaterThan15(numbers));
        Console.WriteLine();

        Console.WriteLine("Все исходные числа:");
        printer.PrintAll(numbers);
    }
}