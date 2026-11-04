using System;
using System.Collections.Generic;

public class NumberSearcher
{
    private  Predicate<int> _isGreaterThan15 = n => n > 15;

    public int FindFirstGreaterThan15(List<int> numbers)
    {
        return numbers.Find(_isGreaterThan15);
    }
}