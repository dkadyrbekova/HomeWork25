using System;
using System.Collections.Generic;

public static class EmployeeExtensions
{
    
    public static List<Employee> Filter(
        this List<Employee> employees,
        Predicate<Employee> predicate)
    {
        List<Employee> result = new();

        foreach (Employee employee in employees)
        {
            if (predicate(employee))
            {
                result.Add(employee);
            }
        }

        return result;
    }

     //Вызывает переданное действие для каждого сотрудника
    public static void Print(
        this List<Employee> employees,
        Action<Employee> action)
    {
        foreach (Employee employee in employees)
        {
            action(employee);
        }
    }
}