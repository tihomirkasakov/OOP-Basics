using System.Collections.Generic;

public static class ProviderFactory
{
    public static Provider Create(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        Provider provider = null;
        if (type == "Solar")
        {
            provider=new SolarProvider(id, energyOutput);
        }
        else
        {
            provider=new PressureProvider(id, energyOutput);
        }
        return provider;
    }
}