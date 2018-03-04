﻿using System;
using System.Collections.Generic;
using System.Text;

public class Private : Soldier, IPrivate, ISoldier
{
    public double Salary { get; protected set; }

    public Private(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";
    }
}
