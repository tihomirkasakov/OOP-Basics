using System;
using System.Text;

public class Seat : Car, ICar
{
    public Seat(string model, string color)
        : base(model, color)
    {
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.Color} {GetType()} {this.Model}");
        sb.AppendLine(Start());
        sb.Append(Stop());
        return sb.ToString();
    }
}