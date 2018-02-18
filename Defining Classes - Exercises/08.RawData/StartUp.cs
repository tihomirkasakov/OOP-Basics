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

            var speed = int.Parse(input[1]);
            var power = int.Parse(input[2]);
            Engine engine = new Engine(speed, power);

            var weight = int.Parse(input[3]);
            var type = input[4];
            Cargo cargo = new Cargo(weight, type);

            List<Tire> tires = new List<Tire>();
            for (int j = 5; j < input.Length - 1; j += 2)
            {
                var pressure = double.Parse(input[j]);
                var age = int.Parse(input[j + 1]);
                Tire tire = new Tire(pressure, age);
                tires.Add(tire);
            }
            Car car = new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        var command = Console.ReadLine();

        if (command == "fragile")
        {
            foreach (var car in cars.Where(c => c.Cargo.Type == command && c.Tires.Any(p => p.Pressure < 1)))
            {
                Console.WriteLine(car.Model);
            }
        }
        else if (command=="flamable")
        {
            foreach (var car in cars.Where(c=>c.Cargo.Type==command&&c.Engine.EnginePower>250))
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
