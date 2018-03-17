using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private string mode;

    private double totalEnergy;
    private double oreMined;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        string result;
        try
        {
            if (type == "Hammer")
            {
                harvesters.Add(new HammerHarvester(id, oreOutput, energyRequirement));
                result = $"Successfully registered {type} Harvester - {id}";
            }
            else
            {
                var sonicFactor = int.Parse(arguments[4]);
                harvesters.Add(new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor));
                result = $"Successfully registered {type} Harvester - {id}";
            }
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }

        return result;
    }
    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        string result;
        try
        {
            if (type == "Solar")
            {
                providers.Add(new SolarProvider(id, energyOutput));
                result = $"Successfully registered {type} Provider - {id}";
            }
            else
            {
                providers.Add(new PressureProvider(id, energyOutput));
                result = $"Successfully registered {type} Provider - {id}";
            }
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
        return result;
    }
    public string Day()
    {
        var totalDayEnergy = this.providers.Sum(p => p.EnergyOutput);
        var energyNeeded = this.harvesters.Sum(h => h.EnergyRequirement);
        var totalDayOre = this.harvesters.Sum(h => h.OreOutput);

        if (this.mode == "Half")
        {
            energyNeeded *= 0.6;
            totalDayOre *= 0.5;
        }
        else if (this.mode == "Energy")
        {
            energyNeeded = 0;
            totalDayOre = 0;
        }
        this.totalEnergy += totalDayEnergy;

        if (this.totalEnergy >= energyNeeded)
        {
            this.totalEnergy -= energyNeeded;
            this.oreMined += totalDayOre;
        }
        else
        {
            totalDayOre = 0;
        }

        StringBuilder result = new StringBuilder();
        result.AppendLine("A day has passed.");
        result.AppendLine($"Energy Provided: {totalDayEnergy}");
        result.Append($"Plumbus Ore Mined: {totalDayOre}");
        return result.ToString();
    }
    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {this.mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        StringBuilder result = new StringBuilder();
        var harvester = this.harvesters.FirstOrDefault(h => h.Id == id);
        var provider = this.providers.FirstOrDefault(p => p.Id == id);
        if (harvester == null && provider == null)
        {
            result.Append($"No element found with id - {id}");
        }
        else if (harvester!=null)
        {
            return harvester.ToString();
        }
        else
        {
            return provider.ToString();
        }

        return result.ToString();
    }
    public string ShutDown()
    {
        StringBuilder result = new StringBuilder();
        result.AppendLine("System Shutdown");
        result.AppendLine($"Total Energy Stored: {this.totalEnergy}");
        result.Append($"Total Mined Plumbus Ore: {this.oreMined}");
        return result.ToString();
    }

}