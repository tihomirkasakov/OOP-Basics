using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : NotRobot, IBuyer
{
    private string group;
    private int age;
    private int food;


    public Rebel(string name, int age, string group)
        : base(name)
    {
        this.Group = group;
        this.Age = age;
        this.Food = 0;
    }

    public int Food
    {
        get { return food; }
        set { food = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public void BuyFood()
    {
        this.Food += 5;
    }

}