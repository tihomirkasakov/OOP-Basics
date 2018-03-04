using System;

public class Pet : NotRobot, IBirthday
{
    public Pet(string name,string birthday)
        :base(name,birthday)
    {

    }
}