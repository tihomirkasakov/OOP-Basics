﻿using System;

class StartUp
{
    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount();
        acc.ID = 1;
        acc.Balance = 15;

        Console.WriteLine(acc);
    }
}