using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private int id;

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public override string ToString()
    {
        return $"Account {this.ID}, balance {this.Balance}";
    }
}