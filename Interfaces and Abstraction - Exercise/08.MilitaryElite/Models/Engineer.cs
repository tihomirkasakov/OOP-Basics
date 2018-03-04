﻿using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer, ISpecialisedSoldier, IPrivate, ISoldier
{
    public List<IRepair> Repairs { get; private set; }

    public Engineer(int id, string firstName, string lastName, double salary, string corps, List<IRepair> repairs)
        : base(id, firstName, lastName, salary, corps)
    {
        this.Repairs = repairs;
    }

    public override string ToString()
    {
        var builder = new StringBuilder()
            .AppendLine(base.ToString())
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Repairs:");

        foreach (var repair in this.Repairs)
        {
            builder.AppendLine(repair.ToString());
        }

        var result = builder.ToString().TrimEnd();

        return result;
    }
}
