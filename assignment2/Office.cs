using System;

class Office
{
    private List<Employee> employees;
    private List<Department> departments;

    public Office()
    {
        employees = new List<Employee>();
        departments = new List<Department>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public void PrintEmployees()
    {
        Console.WriteLine("Employees:");
        foreach (var employee in employees)
        {
            employee.PrintDetails();
        }
    }
 public void PrintDepartments()
    {
        Console.WriteLine("Departments:");
        foreach (var department in departments)
        {
            department.PrintDetails();
        }
    }
}