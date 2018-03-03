﻿using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public virtual void ProduceSound()
    {
        Console.WriteLine();
    }

}
