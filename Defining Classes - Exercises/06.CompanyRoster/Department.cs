using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Department
{
    private List<Employee> employees;
    private string name;

    public List<Employee> Employees
    {
        get { return employees; }
        set { employees = value; }
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Department(string name)
    {
        this.Employees = new List<Employee>();
        this.name = name;
    }

    public void AddEmployee(Employee employee)
    {
        this.Employees.Add(employee);
    }

    public decimal AverageSalary=> this.Employees.Select(s => s.Salary).Average();
}