using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var numberOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < numberOfCars; i++)
        {
            var input = Console.ReadLine().Split();
            var model = input[0];
            var fuel = decimal.Parse(input[1]);
            var consumption = decimal.Parse(input[2]);
                cars.Add(new Car(model,fuel,consumption));
        }

        var command = Console.ReadLine();
        while (command != "End")
        {
            var tokens = command.Split();
            var model = tokens[1];
            var distance = int.Parse(tokens[2]);

            Car car = cars.First(c => c.CarModel == model);

            if (!car.CanTravelDistance(distance))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            command = Console.ReadLine();
        }

        foreach (var c in cars)
        {
            Console.WriteLine($"{c.CarModel} {c.Fuel:f2} {c.Distance}");
        }
    }
}