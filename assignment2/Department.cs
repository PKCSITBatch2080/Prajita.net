using System;

class Department : IDepartment
{
    public string Name { get; set; }

    public Department(string name)
    {
        Name = name;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Department: {Name}");
    }
}