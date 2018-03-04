﻿using System;

public class StartUp
{
    static void Main(string[] args)
    {
        string citizenInfo;
        while ((citizenInfo = Console.ReadLine()) != "End")
        {
            var citizenArgs = citizenInfo.Split();

            var name = citizenArgs[0];
            var country = citizenArgs[1];
            var age = int.Parse(citizenArgs[2]);

            IPerson person = new Citizen(name, country, age);
            IResident resident = new Citizen(name, country, age);

            Console.WriteLine(person.GetName());
            Console.WriteLine(resident.GetName());
        }
    }
}