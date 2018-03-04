using System.Text;

public class Ferrari:ICar
{
    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Driver
    {
        get { return driver; }
        set { driver = value; }
    }

    public string Model => "488-Spider";

    public string Break()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.Model}/{this.Break()}/{this.Gas()}/{this.Driver}");
        return sb.ToString();
    }
}