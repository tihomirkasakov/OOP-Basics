using System;
using System.Collections.Generic;
using System.Text;

public class Car : ICar
{
    private string model;
    private string color;

    public Car(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model
    {
        get { return this.model; }
        set { model = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { color = value; }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }


}