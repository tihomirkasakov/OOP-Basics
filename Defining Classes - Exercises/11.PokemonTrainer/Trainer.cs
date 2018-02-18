using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemon;

    public Trainer(string name, int badges = 0)
    {
        this.Name = name;
        this.Badges = badges;
        this.Pokemon = new List<Pokemon>();
    }

    public List<Pokemon> Pokemon
    {
        get { return pokemon; }
        set { pokemon = value; }
    }

    public int Badges
    {
        get { return badges; }
        set { badges = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.Pokemon.Add(pokemon);
    }

    public void IncreaseBadges()
    {
        Badges++;
    }

    public void ReducePokemonsHealth()
    {
        this.Pokemon.ForEach(p => p.ReduceHealth());
    }

    public void RemoveDead()
    {
        this.Pokemon = this.Pokemon
            .Where(p => p.Health > 0)
            .ToList();
    }
}
