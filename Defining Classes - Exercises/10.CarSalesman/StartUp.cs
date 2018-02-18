using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var engineNumber = int.Parse(Console.ReadLine());
        List<Engine> engines = new List<Engine>();
        List<Car> cars = new List<Car>();
        for (int i = 0; i < engineNumber; i++)
        {
            var engineTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var model = engineTokens[0];
            var power = int.Parse(engineTokens[1]);
            int displacement;
            string efficiency = "";
            Engine engine = new Engine(model,power);
            if (engineTokens.Length==4)
            {
                displacement = int.Parse(engineTokens[2]);
                efficiency = engineTokens[3];
                engine.Displacement = displacement;
                engine.Efficiency = efficiency;
            }
            else if (engineTokens.Length==3)
            {
                var hasDisplacement = int.TryParse(engineTokens[2], out displacement);
                if (!hasDisplacement)
                {
                    efficiency = engineTokens[2];
                    engine.Efficiency = efficiency;
                }
                else
                {
                    engine.Displacement = displacement;
                }
            }
            engines.Add(engine);
        }

        var carNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < carNumber; i++)
        {
            var carTokens = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            var model = carTokens[0];
            var engine = engines.First(e => e.Model == carTokens[1]);
            int weight;
            var color = "";
            Car car = new Car(model, engine);
            if (carTokens.Length==4)
            {
                weight = int.Parse(carTokens[2]);
                color = carTokens[3];
                car.Weight = weight;
                car.Color = color;
            }
            else if (carTokens.Length==3)
            {
                bool hasWeight = int.TryParse(carTokens[2], out weight);
                if (!hasWeight)
                {
                    color = carTokens[2];
                    car.Color = color;
                }
                else
                {
                    car.Weight = weight;
                }
            }
            cars.Add(car);
        }
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}