using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var numberOfEmployees = int.Parse(Console.ReadLine());
        var departments = new List<Department>();
        for (int i = 0; i < numberOfEmployees; i++)
        {
            var employeeInfo = Console.ReadLine().Split();
            var name = employeeInfo[0];
            var salary = decimal.Parse(employeeInfo[1]);
            var position = employeeInfo[2];
            var department = employeeInfo[3];
            var email = "n/a";
            var age=-1;

            if (employeeInfo.Length == 6)
            {
                email = employeeInfo[4];
                age = int.Parse(employeeInfo[5]);
            }

            else if (employeeInfo.Length == 5)
            {
                bool isAge = int.TryParse(employeeInfo[4], out age);
                if (!isAge)
                {
                    email = employeeInfo[4];
                    age = -1;
                }
            }

            if (!departments.Any(d => d.Name == department))
            {
                Department dep = new Department(department);
                departments.Add(dep);
            }

            Employee employee = new Employee(name, salary, position, email, age);
            var deparmentName = departments.FirstOrDefault(d => d.Name == department);
            deparmentName.AddEmployee(employee);

        }

        var highestSalaryDep = departments.OrderByDescending(s => s.AverageSalary).First();
        Console.WriteLine($"Highest Average Salary: {highestSalaryDep.Name}");

        foreach (var emp in highestSalaryDep.Employees.OrderByDescending(s=>s.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }
    }
}