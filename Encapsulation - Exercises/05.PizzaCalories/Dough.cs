using System;

public class Dough
{
    public const int caloriesPerGram = 2;
    private string flourType;
    private string bakingTechnique;
    private double weight;


    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get { return this.flourType; }
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    private string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }

    private double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }

    public double Calories()
    {
        double calories = caloriesPerGram * this.Weight;
        switch (this.FlourType.ToLower())
        {
            case "white":
                calories *= 1.5;
                break;
            case "wholegrain":
                calories *= 1;
                break;
        }
        switch (this.BakingTechnique.ToLower())
        {
            case "crispy":
                calories *= 0.9;
                break;
            case "chewy":
                calories *= 1.1;
                break;
            case "homemade":
                calories *= 1;
                break;
        }
        return calories;
    }
}