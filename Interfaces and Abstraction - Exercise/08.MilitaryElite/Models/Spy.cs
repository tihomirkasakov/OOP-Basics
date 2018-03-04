using System;
using System.Collections.Generic;
using System.Text;

public class Spy : Soldier, ISpy, ISoldier
{
    public int CodeNumber { get; private set; }

    public Spy(int id, string firstName, string lastName, int codeName)
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeName;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}{Environment.NewLine}"
            + $"Code Number: {this.CodeNumber}";
    }
}