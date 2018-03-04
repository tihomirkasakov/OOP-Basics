using System;
using System.Collections.Generic;
using System.Text;

public class Robot : Person, IRobot, IPerson
{
    private string model;

    public Robot(string model, string id)
        : base(id)
    {
        this.Model = model;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}
