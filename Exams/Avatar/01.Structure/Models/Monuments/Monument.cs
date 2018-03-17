public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public abstract int GetAffinity();

    public override string ToString()
    {
        string monumentType = this.GetType().Name;
        int monumentIndex = monumentType.IndexOf("Monument");
        monumentType = monumentType.Insert(monumentIndex, " ");
        return $"{monumentType}: {this.Name}, ";
    }
}