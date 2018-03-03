using System;
using System.Collections.Generic;
using System.Text;

public class Worker:Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName,string lastName, decimal weekSalary, decimal workHoursPerDay)
        :base(firstName,lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            if (value<1||value>12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            workHoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value<10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    private decimal CalculateHourSalary(decimal weekSalary, decimal workHoursPerDay)
    {
        decimal result = weekSalary / (workHoursPerDay * 5m);
        return result;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {base.FirstName}");
        sb.AppendLine($"Last Name: {base.LastName}");
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
        sb.Append($"Salary per hour: {CalculateHourSalary(this.WeekSalary, this.WorkHoursPerDay):f2}");
        return sb.ToString();
    }
}
