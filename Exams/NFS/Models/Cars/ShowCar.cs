using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ShowCar : Car
{
    public int Stars { get; private set; }
    public ShowCar(string brand, string model, int year, int hp, int acceleration, int suspension, int durability)
        : base(brand, model, year, hp, acceleration, suspension, durability)
    {
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);

        this.Stars += tuneIndex;
    }

    public override string ToString()
    {
        string result = base.ToString() + $"{this.Stars} *";

        return result;
    }
}