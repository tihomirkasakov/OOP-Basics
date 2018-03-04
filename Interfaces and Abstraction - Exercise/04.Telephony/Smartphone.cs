using System;
using System.Linq;

public class Smartphone : ICallable, IBrowsable
{
    public string Browse(string site)
    {
        if (site.Any(Char.IsDigit))
        {
            return "Invalid URL!";
        }

        return $"Browsing: {site}!";
    }

    public string Call(string number)
    {
        if (!number.All(Char.IsDigit))
        {
            return "Invalid number!";
        }

        return $"Calling... {number}";
    }
}