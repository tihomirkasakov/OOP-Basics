using System;
using System.Reflection;

public class StartUp
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var family = new Family();
        for (int i = 0; i < number; i++)
        {
            var input = Console.ReadLine().Split();
            string name = "";
            var age = 0;
            if (input.Length == 0)
            {
                Person person = new Person();
                family.AddMember(person);
            }
            else if (input.Length == 1)
            {
                age = int.Parse(input[0]);
                Person person = new Person(age);
                family.AddMember(person);
            }
            else
            {
                name = input[0];
                age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
        }
        var olderThan30 = family.OlderThan30();
        foreach (var person in olderThan30)
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}
