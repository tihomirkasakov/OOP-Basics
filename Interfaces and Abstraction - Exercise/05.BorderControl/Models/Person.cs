using System;
using System.Collections.Generic;
using System.Text;

public class Person : IPerson
{
    private string id;

    public Person(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
}