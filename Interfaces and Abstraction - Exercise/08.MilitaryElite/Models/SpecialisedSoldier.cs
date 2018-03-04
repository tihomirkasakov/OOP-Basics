﻿using System;
using System.Linq;

public class SpecialisedSoldier : Private, ISpecialisedSoldier, IPrivate, ISoldier
{
    private readonly string[] ValidCorps = { "Airforces", "Marines" };

    private string corps;

    public string Corps
    {
        get { return this.corps; }
        private set
        {
            if (!this.ValidCorps.Contains(value))
            {
                throw new ArgumentException("Invalid Corps!");
            }

            this.corps = value;
        }
    }

    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }
}