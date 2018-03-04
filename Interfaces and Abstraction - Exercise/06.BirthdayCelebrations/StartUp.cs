using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var input = Console.ReadLine();
        List<IBirthday> persons = new List<IBirthday>();
        while (input != "End")
        {
            var tokens = input.Split();
            var type = tokens[0];
            if (type == "Citizen")
            {
                var name = tokens[1];
                var age = int.Parse(tokens[2]);
                var id = tokens[3];
                var birthday = tokens[4];
                Citizen citizen = new Citizen(name, age, id, birthday);
                persons.Add(citizen);
            }
            else if (type == "Pet")
            {
                var name = tokens[1];
                var birthday = tokens[2];
                Pet pet = new Pet(name, birthday);
                persons.Add(pet);
            }
            else if (type == "Robot")
            {
                input = Console.ReadLine();
                continue;
            }

            input = Console.ReadLine();
        }

        var searchYear = int.Parse(Console.ReadLine());

        foreach (var person in persons.Where(p => p.Birthday.Year == searchYear).Select(p=>p.Birthday))
        {
            Console.WriteLine($"{person:dd/mm/yyyy}");
        }

    }
}