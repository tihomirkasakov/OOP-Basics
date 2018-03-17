using System;
using System.Linq;

internal class Engine
{
    private bool isRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = input[0];
            input.Remove(command);

            switch (command)
            {
                case "Bender":
                    nationsBuilder.AssignBender(input);
                    break;
                case "Monument":
                    nationsBuilder.AssignMonument(input);
                    break;
                case "Status":
                    string status = nationsBuilder.GetStatus(input[0]);
                    Console.WriteLine(status);
                    break;
                case "War":
                    nationsBuilder.IssueWar(input[0]);
                    break;
                case "Quit":
                    string record = nationsBuilder.GetWarsRecord();
                    Console.WriteLine(record);
                    isRunning = false;
                    break;
            }
        }
    }
}