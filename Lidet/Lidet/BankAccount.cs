using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lidet
{
    internal class BankAccount
    {
        private string owner;
        private double balance;

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public double Balance
        {
            get => balance;
        }


        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount:F2}. New balance: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount > balance)
                    Console.WriteLine("Insufficient funds.");
                else if (amount <= 0)
                    Console.WriteLine("Withdrawal amount must be positive.");
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew ${amount:F2}. New balance: ${balance:F2}");
                }
            }
        }

        public bool HasSufficientFunds(double amoun) => balance >= amoun;

        public void PrintSummary()
        {
            Console.WriteLine($"\n--- Account Summary ---");
            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"Balance: ${balance:F2}");
            Console.WriteLine($"Status: {(balance > 0 ? "Active" : "Empty")}");
            Console.WriteLine($"-----------------------\n");
        }

    }
}
