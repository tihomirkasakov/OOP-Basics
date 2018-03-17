using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nation
{
    public List<Bender> benders;
    public List<Monument> monuments;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public double TotalPower()
    {
        double totalBenderPower = this.benders.Sum(b => b.GetPower());
        int totalMonumentPower = this.monuments.Sum(m => m.GetAffinity());

        double totalPower = (totalBenderPower / 100) * totalMonumentPower;
        return totalPower;
    }


    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append("Benders:");
        if (this.benders.Any())
        {
            result.AppendLine().AppendLine(string.Join(Environment.NewLine, this.benders.Select(bender => $"###{bender}")));
        }
        else
        {
            result.AppendLine(" None");
        }

        result.Append("Monuments:");
        if (this.monuments.Any())
        {
            result.AppendLine().Append(string.Join(Environment.NewLine, this.monuments.Select(monument => $"###{monument}")));
        }
        else
        {
            result.Append(" None");
        }

        return result.ToString();
    }

    public void DeclareDefeat()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }
}