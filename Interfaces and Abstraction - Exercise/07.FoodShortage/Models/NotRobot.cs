using System;

public class NotRobot : IBirthday
{
    private string name;
    private DateTime birthday;

    public NotRobot(string name)
    {
        this.Name = name;
    }

    public NotRobot(string name, string birthday):this(name)
    {
        this.Birthday = DateTime.ParseExact(birthday, "dd/mm/yyyy", null);
    }

    public DateTime Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}