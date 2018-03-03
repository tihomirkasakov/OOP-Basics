using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int happiness = 0;
        for (int i = 0; i < input.Length; i++)
        {
            var food = input[i].ToLower();
            switch (food)
            {
                case "cram":
                    happiness += 2;
                    break;
                case "lembas":
                    happiness += 3;
                    break;
                case "apple":
                    happiness++;
                    break;
                case "melon":
                    happiness++;
                    break;
                case "honeycake":
                    happiness += 5;
                    break;
                case "mushrooms":
                    happiness -= 10;
                    break;
                default:
                    happiness--;
                    break;
            }

        }

        Console.WriteLine(happiness);

        if (happiness < -5)
        {
            Console.WriteLine("Angry");
        }

        else if (happiness < 1)
        {
            Console.WriteLine("Sad");
        }

        else if (happiness < 16)
        {
            Console.WriteLine("Happy");
        }

        else
        {
            Console.WriteLine("JavaScript");
        }

    }
}