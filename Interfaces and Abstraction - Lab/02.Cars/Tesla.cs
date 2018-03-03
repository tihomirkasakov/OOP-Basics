using System.Text;

public class Tesla : Car, IElectricCar, ICar
{
    private int battery;

    public Tesla(string model, string color, int battery)
        :base(model,color)
    {
        this.Battery = battery;
    }

    public int Battery
    {
        get { return this.battery; }
        set { battery = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {GetType()} {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}