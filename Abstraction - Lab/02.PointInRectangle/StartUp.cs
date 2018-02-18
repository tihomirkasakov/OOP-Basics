using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var rectangleCoords = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Rectangle rectangle = new Rectangle(rectangleCoords[0], rectangleCoords[1], rectangleCoords[2], rectangleCoords[3]);
        var numberOfPoints = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPoints; i++)
        {
            var points = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(rectangle.Contains(new Point(points[0],points[1])));
        }
    }
}
