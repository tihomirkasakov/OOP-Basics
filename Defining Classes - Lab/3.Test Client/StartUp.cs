using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        while (input[0]!="End")
        {
            var command = input[0];
            switch (command)
            {
                case "Create":
                    Create(input, accounts);
                    break;
                case "Deposit":
                    Deposit(input, accounts);
                    break;
                case "Withdraw":
                    Withdraw(input, accounts);
                    break;
                case "Print":
                    Print(input, accounts);
                    break;
            }
            input = Console.ReadLine().Split();
        }
    }

    private static void Print(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[id].ToString());
        }
    }

    private static void Withdraw(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        var amount = decimal.Parse(input[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance<amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Withdraw(amount);
        }
    }

    private static void Deposit(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        var amount = decimal.Parse(input[2]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(amount);
        }
    }

    private static void Create(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.Id = id;
            accounts.Add(id, acc);
        }
    }
}
