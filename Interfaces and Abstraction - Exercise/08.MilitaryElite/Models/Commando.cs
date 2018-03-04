﻿using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando, ISpecialisedSoldier, IPrivate, ISoldier
{
    public List<IMission> Missions { get; private set; }

    public Commando(int id, string firstName, string lastName, double salary, string corps, List<IMission> missions)
        : base(id, firstName, lastName, salary, corps)
    {
        this.Missions = missions;
    }

    public override string ToString()
    {
        var builder = new StringBuilder()
            .AppendLine(base.ToString())
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Missions:");

        foreach (var mission in this.Missions)
        {
            builder.AppendLine(mission.ToString());
        }

        var result = builder.ToString().TrimEnd();

        return result;
    }
}
