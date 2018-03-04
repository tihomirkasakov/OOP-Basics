using System;
using System.Collections.Generic;
using System.Text;

public class Soldier : ISoldier
{
    public int Id { get; protected set; }

    public string FirstName { get; protected set; }

    public string LastName { get; protected set; }

    public Soldier(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
}