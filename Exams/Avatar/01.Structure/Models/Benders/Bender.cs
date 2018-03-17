public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public int Power
    {
        get { return this.power; }
        protected set { this.power = value; }
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public abstract double GetPower();

    public override string ToString()
    {
        string benderType = this.GetType().Name;
        int benderIndex = benderType.IndexOf("Bender");
        benderType = benderType.Insert(benderIndex, " ");

        return $"{benderType}: {this.Name}, Power: {this.Power}, ";
    }
}