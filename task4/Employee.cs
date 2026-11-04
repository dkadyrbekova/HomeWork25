public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, int age, int salary, string department)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
        Department = department;
    }
}  