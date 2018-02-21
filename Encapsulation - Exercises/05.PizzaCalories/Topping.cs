using System;

public class Topping
{
    private const int baseCalories = 2;

    private string classes;
    private double weight;

    public Topping(string classes, double weight)
    {
        this.Classes = classes;
        this.Weight = weight;
    }

    private string Classes
    {
        get { return this.classes; }
        set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.classes = value;
        }
    }

    private double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.Classes} weight should be in the range [1..50].");

            }
            this.weight = value;
        }
    }

    public double Calories()
    {
        double calories = baseCalories * this.Weight;
        switch (this.Classes.ToLower())
        {
            case "meat":
                calories *= 1.2;
                break;
            case "veggies":
                calories *= 0.8;
                break;
            case "cheese":
                calories *= 1.1;
                break;
            case "sauce":
                calories *= 0.9;
                break;
        }

        return calories;
    }
}