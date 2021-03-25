using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
            balance = 0.0;
        }

        public void Deposit(double amt)
        {
            balance = amt;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
