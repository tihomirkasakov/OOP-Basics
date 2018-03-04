using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var inputNumber = int.Parse(Console.ReadLine());
        var buyers = new List<IBuyer>();
        for (int i = 0; i < inputNumber; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);
            var id = input[2];
            if (input.Length == 4)
            {
                var birthdate = input[3];
                IBuyer citizen = new Citizen(name, age, id, birthdate);
                buyers.Add(citizen);
            }
            else if (input.Length==3)
            {
                IBuyer rebel = new Rebel(name, age, id);
                buyers.Add(rebel);
            }
        }

        var buyerName = Console.ReadLine();
        while (buyerName != "End")
        {
            var buyer = buyers.FirstOrDefault(b => b.Name == buyerName);
            if (buyer!=null)
            {
                buyer.BuyFood();
            }
            buyerName = Console.ReadLine();
        }

        var totalFoodBrought = buyers.Sum(b => b.Food);
        Console.WriteLine(totalFoodBrought);
    }
}