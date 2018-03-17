using System.Collections.Generic;
using System.Linq;

public class PerformanceCar : Car
{
    public List<string> AddOns { get; private set; }

    public PerformanceCar(string brand, string model, int year, int hp, int acceleration, int suspension, int durability)
        : base(brand, model, year, hp, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        base.HorsePower += (int)(base.HorsePower * 0.5);
        base.Suspension -= (int)(base.Suspension * 0.25);
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);

        this.AddOns.Add(addOn);
    }

    public override string ToString()
    {
        string addOnsViewModel = this.AddOns.Any() ? string.Join(", ", this.AddOns) : "None";

        var result = base.ToString() + $"Add-ons: {addOnsViewModel}";

        return result;
    }
}