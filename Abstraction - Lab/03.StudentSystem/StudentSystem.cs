using System;
using System.Collections.Generic;
using System.Text;

public class StudentSystem
{
    private Dictionary<string, Student> repo;

    public StudentSystem()
    {
        repo = new Dictionary<string, Student>();
    }

    public void ParseCommand(string command)
    {
        string[] args = command.Split();

        if (args[0] == "Create")
        {
            Create(args);
        }
        else if (args[0] == "Show")
        {
            Show(args);

        }
    }

    private void Show(string[] args)
    {
        var name = args[1];
        if (repo.ContainsKey(name))
        {
            var student = repo[name];
            string view = $"{student.Name} is {student.Age} years old.";

            if (student.Grade >= 5.00)
            {
                view += " Excellent student.";
            }
            else if (student.Grade < 5.00 && student.Grade >= 3.50)
            {
                view += " Average student.";
            }
            else
            {
                view += " Very nice person.";
            }

            Console.WriteLine(view);
        }
    }

    private void Create(string[] args)
    {
        var name = args[1];
        var age = int.Parse(args[2]);
        var grade = double.Parse(args[3]);
        if (!repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            repo[name] = student;
        }
    }
}
