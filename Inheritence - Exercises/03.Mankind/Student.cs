using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if (value.Length < 5 || value.Length > 10 || !value.All(x => char.IsLetterOrDigit(x)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {base.FirstName}");
        sb.AppendLine($"Last Name: {base.LastName}");
        sb.AppendLine($"Faculty number: {this.FacultyNumber}");
        return sb.ToString();
    }
}
