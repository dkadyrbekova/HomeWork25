using System;
using System.Collections.Generic;
using System.Linq;

public class NumberTransformer
{
    private Func<int, int> _mul = n => n * 2;

    public List<int> DoubleAll(List<int> numbers)
    {
        return numbers.Select(_mul).ToList();
    }
}