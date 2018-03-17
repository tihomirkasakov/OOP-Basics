using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public string Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine($"{this.GetType().Name.Replace("Provider",string.Empty)} Provider - {id}");
        result.Append($"Energy Output: {this.EnergyOutput}");
        return result.ToString();
    }
}