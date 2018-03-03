using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        var input = Console.ReadLine();
        while (input!="Beast!")
        {
            try
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 3)
                {
                    throw new ArgumentException("Invalid input!");
                }
                var name = tokens[0];
                if (!int.TryParse(tokens[1], out int age))
                {
                    throw new ArgumentException("Invalid input!");
                }
                var gender = tokens[2];

                switch (input)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(name, age);
                        animals.Add(tomcat);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        animals.Add(kitten);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            input = Console.ReadLine();
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetType().Name);
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            animal.ProduceSound();
        }
    }
}
