using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warHistory;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air",new Nation()},
            {"Earth",new Nation()},
            {"Fire", new Nation()},
            {"Water",new Nation()}
        };
        this.warHistory = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondaryParameter = double.Parse(benderArgs[3]);
        Bender bender = null;
        switch (type)
        {
            case "Air":
                bender = new AirBender(name, power, secondaryParameter);
                break;
            case "Earth":
                bender = new EarthBender(name, power, secondaryParameter);
                break;
            case "Fire":
                bender = new FireBender(name, power, secondaryParameter);
                break;
            case "Water":
                bender = new WaterBender(name, power, secondaryParameter);
                break;
            default:
                throw new ArgumentException();
        }

        nations[type].benders.Add(bender);
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);
        Monument monument = null;
        switch (type)
        {
            case "Air":
                monument = new AirMonument(name, affinity);
                break;
            case "Earth":
                monument = new EarthMonument(name, affinity);
                break;
            case "Fire":
                monument = new FireMonument(name, affinity);
                break;
            case "Water":
                monument = new WaterMonument(name, affinity);
                break;
            default:
                throw new ArgumentException();
        }

        nations[type].monuments.Add(monument);

    }
    public string GetStatus(string nationsType)
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine($"{nationsType} Nation")
            .Append(this.nations[nationsType]);

        return result.ToString();
    }
    public void IssueWar(string nationsType)
    {
        double nationMaxPower = this.nations.Max(kvp => kvp.Value.TotalPower());
        foreach (var nation in nations.Values)
        {
            if (nation.TotalPower() != nationMaxPower)
            {
                nation.DeclareDefeat();
            }
        }

        this.warHistory.Add($"War {this.warHistory.Count + 1} issued by {nationsType}");
    }
    public string GetWarsRecord()
    {
        return string.Join(Environment.NewLine, this.warHistory);
    }

}