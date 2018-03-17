using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private bool running = true;
    DraftManager draftManager = new DraftManager();
    public Engine()
    {

    }

    public void Run()
    {
        while (running)
        {
            var commandArgs = Console.ReadLine().Split().ToList();
            var command = commandArgs[0];
            commandArgs.RemoveAt(0);

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(commandArgs));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(commandArgs));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(commandArgs));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(commandArgs));
                    break;
                case "Shutdown":
                    Console.WriteLine(draftManager.ShutDown());
                    running = false;
                    break;
            }
        }
    }
}