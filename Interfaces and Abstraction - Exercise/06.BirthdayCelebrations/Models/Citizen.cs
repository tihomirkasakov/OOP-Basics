using System;

internal class Citizen : NotRobot, IIdentity, IBirthday
{
    private string id;
    private int age;

    public Citizen(string name, int age, string id, string birthday)
        : base(name, birthday)
    {
        this.Id = id;
        this.Age = age;
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}