public class Robot : IIdentity
{
    private string model;
    private string id;

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}