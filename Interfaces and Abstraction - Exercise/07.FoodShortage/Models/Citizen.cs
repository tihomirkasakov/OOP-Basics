using System;

internal class Citizen : NotRobot, IIdentity, IBirthday, IBuyer
{
    private string id;
    private int age;


    public Citizen(string name, int age, string id, string birthday)
        : base(name, birthday)
    {
        this.Id = id;
        this.Age = age;
        this.Food = 0;
    }

    public int Food { get; private set; }

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

    public void BuyFood()
    {
        this.Food += 10;
    }
}