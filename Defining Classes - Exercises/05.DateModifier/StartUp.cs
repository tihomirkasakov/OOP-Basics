using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();
        var diff = new DateModifier();

        Console.WriteLine(diff.DaysDifference(firstDate,secondDate));
    }
}