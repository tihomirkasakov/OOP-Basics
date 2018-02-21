using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var lenght = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        Box box = null;
        try
        {
            box = new Box(lenght, width, height);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
        Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():f2}");
        Console.WriteLine($"Volume - {box.GetVolume():f2}");
    }
}
