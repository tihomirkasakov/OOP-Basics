using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        PriceCalculator price = new PriceCalculator(input);
        Console.WriteLine(price.TotalPrice().ToString("f2"));
    }
}
