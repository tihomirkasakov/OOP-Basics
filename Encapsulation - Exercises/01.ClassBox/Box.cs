using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double lenght, double width, double height)
    {
        this.length = lenght;
        this.width = width;
        this.height = height;
    }

    public double GetSurfaceArea()
    {
        double surfaceArea = 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * this.height;
        return surfaceArea;
    }

    public double GetLateralSurface()
    {
        double lateralSurface = 2 * this.length * this.height + 2 * this.width * this.height;
        return lateralSurface;
    }

    public double GetVolume()
    {
        double volume = this.length * this.width * this.height;
        return volume;
    }
}