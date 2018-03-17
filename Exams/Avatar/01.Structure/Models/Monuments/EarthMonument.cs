public class EarthMonument : Monument
{
    private int earthAffinity;

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        private set { this.earthAffinity = value; }
    }
    public override int GetAffinity() => this.EarthAffinity;

    public override string ToString()
    {
        return base.ToString() + $"Earth Affinity: {this.EarthAffinity}";
    }
}