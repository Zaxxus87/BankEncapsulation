using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount();
            newAccount.Deposit(3.50);
            Console.WriteLine(newAccount.GetBalance());
        }
    }
}
