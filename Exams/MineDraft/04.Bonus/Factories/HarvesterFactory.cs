using System;
using System.Collections.Generic;
using System.Text;

public static class HarvesterFactory
{
    public static Harvester Create(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        if (type == "Hammer")
        {
            return new HammerHarvester(id, oreOutput, energyRequirement);
        }
        else
        {
            var sonicFactor = int.Parse(arguments[4]);
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
    }
}