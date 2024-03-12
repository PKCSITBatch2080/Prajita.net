using System;
using System.Collections.Generic;

class Programs
{
    static void Main(string[] args)
    {
        // Create an office
        Office office = new Office();

        // Add departments
        Department hr = new Department("HR");
        Department it = new Department("IT");
        office.AddDepartment(hr);
        office.AddDepartment(it);

        // Add employees
        Employee emp1 = new Employee("Ram", 30, "HR");
        Employee emp2 = new Employee("Hari", 25, "IT");
        office.AddEmployee(emp1);
        office.AddEmployee(emp2);

        // Print employees and departments
        office.PrintEmployees();
        office.PrintDepartments();
    }
}
