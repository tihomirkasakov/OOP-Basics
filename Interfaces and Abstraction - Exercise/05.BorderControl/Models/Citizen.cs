using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : Person, ICitizen, IPerson
{
    private string name;
    private int age;

    public Citizen(string name, int age, string id)
        :base(id)
    {
        this.Name = name;
        this.Age = age;
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}
