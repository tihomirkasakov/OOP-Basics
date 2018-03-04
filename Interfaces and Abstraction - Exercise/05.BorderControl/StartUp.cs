using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine();
        List<IPerson> persons = new List<IPerson>();
        while (input != "End")
        {
            var tokens = input.Split();
            if (tokens.Length==3)
            {
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var id = tokens[2];
                Citizen citizen = new Citizen(name, age, id);
                persons.Add(citizen);
            }
            else if (tokens.Length==2)
            {
                var model = tokens[0];
                var id = tokens[1];
                Robot robot = new Robot(model, id);
                persons.Add(robot);
            }

            input = Console.ReadLine();
        }

        var searchId = Console.ReadLine();

        foreach (var person in persons.Where(p=>p.Id.EndsWith(searchId)))
        {
            Console.WriteLine(person.Id);
        }
    }
}