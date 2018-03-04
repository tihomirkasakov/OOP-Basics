using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var phoneNumbers = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();

        Smartphone smartphone = new Smartphone();

        foreach (var number in phoneNumbers)
        {
            Console.WriteLine(smartphone.Call(number));

        }

        foreach (var site in sites)
        {
            Console.WriteLine(smartphone.Browse(site));

        }
    }
}