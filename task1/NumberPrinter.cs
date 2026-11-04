using System;
using System.Collections.Generic;

public class NumberPrinter
{
    private Action<int> _print = n => Console.Write(n +  " ");

    public void PrintAll(List<int> numbers)
    {
        numbers.ForEach(_print);
        Console.WriteLine();
    }
}