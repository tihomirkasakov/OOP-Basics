﻿using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.Name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public List<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }

    public List<Person> FirstTeam
    {
        get { return firstTeam; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddPlayer(Person player)
    {
        if (player.Age<40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.reserveTeam.Add(player);
        }
    }
}
