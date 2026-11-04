using System;
using System.Collections.Generic;

public class NumberFilter
{
    private  Predicate<int> _isEven = n => n % 2 == 0;

    public List<int> GetEven(List<int> numbers)
    {
        return numbers.FindAll(_isEven);
    }
}