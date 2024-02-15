using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();

        account._balance = 100;
        Console.WriteLine = ($"Balance; {account._balance}");

        account.Deposit(50);
        Console.WriteLine = ($"Balance; {account._balance}");
    }
}

