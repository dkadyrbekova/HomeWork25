using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new()
        {
            new Employee(1, "Alex", 28, 60000, "IT"),
            new Employee(2, "Bekzat", 24, 45000, "Sales"),
            new Employee(3, "Anna", 31, 52000, "HR"),
            new Employee(4, "Dina", 22, 38000, "IT"),
            new Employee(5, "Aibek", 35, 75000, "IT"),
            new Employee(6, "Marat", 40, 48000, "Finance"),
            new Employee(7, "Aigul", 27, 55000, "Sales"),
            new Employee(8, "Timur", 33, 42000, "IT"),
            new Employee(9, "Nurlan", 45, 90000, "Finance"),
            new Employee(10, "Samat", 26, 50000, "HR")
        };

        // Зарплата выше 50 000
        List<Employee> highSalary = employees.Filter(e => e.Salary > 50000);
        Console.WriteLine("Зарплата выше 50 000:");
        highSalary.Print(e => Console.WriteLine($"{e.Name} - {e.Salary}"));
        Console.WriteLine();

        // Возраст от 25 до 35
        List<Employee> ageRange = employees.Filter(e => e.Age >= 25 && e.Age <= 35);
        Console.WriteLine("Возраст от 25 до 35:");
        ageRange.Print(e => Console.WriteLine($"{e.Name} - {e.Age}"));
        Console.WriteLine();

        // Отдел IT
        List<Employee> itDepartment = employees.Filter(e => e.Department == "IT");
        Console.WriteLine("Отдел IT:");
        itDepartment.Print(e => Console.WriteLine($"{e.Name} - {e.Department}"));
        Console.WriteLine();

        //Полная информация обо всех сотрудниках
        Console.WriteLine("Все сотрудники:");
        employees.Print(e =>
        {
            Console.WriteLine($"Id: {e.Id}");
            Console.WriteLine($"Name: {e.Name}");
            Console.WriteLine($"Age: {e.Age}");
            Console.WriteLine($"Salary: {e.Salary}");
            Console.WriteLine($"Department: {e.Department}");
            Console.WriteLine();
        });

        //Цепочка: IT и зарплата выше 40 000
        Console.WriteLine("IT с зарплатой выше 40 000:");
        employees
            .Filter(e => e.Department == "IT")
            .Filter(e => e.Salary > 40000)
            .Print(e =>
            {
                Console.WriteLine($"Id: {e.Id}");
                Console.WriteLine($"Name: {e.Name}");
                Console.WriteLine($"Age: {e.Age}");
                Console.WriteLine($"Salary: {e.Salary}");
                Console.WriteLine($"Department: {e.Department}");
                Console.WriteLine();
            });
    }
}