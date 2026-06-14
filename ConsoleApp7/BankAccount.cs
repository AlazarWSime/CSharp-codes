using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class BankAccount
    {
        private string owner;
        private double balance;
        private string accountType;
        private string accountNumber;
        private static int totalAccounts = 0;
        public string Owner { get { return owner; }
            private set 
            {
                if (value.Length > 0)
                {
                    owner = value;
                }
                else
                    throw new ArgumentException("Owner name cannot be empty");
            }
        }
        public double Balance { get { return balance; } }
        public string AccountType { get { return accountType; } }
        public static int TotalAccounts
        {
            get => totalAccounts; 
        }
        // Constructor 1 - full details
        public BankAccount(string owner, double initialDeposit, string accountType) 
        {
            this.owner = owner;
            this.accountType = accountType;

            if (initialDeposit >= 0)
            {
                balance = initialDeposit;
            }
            else
            {
                Console.WriteLine("Initial deposite cannot be negative. Set to 0.");
                balance = 0;
            }
        }

        //constructor 2 -no initial deposit, defaults to 0
        public BankAccount(string owner, string accountType) : this(owner, 0, accountType) 
        {
        }

        // Constructor 3 - saving account by default
        public BankAccount(string owner): this(owner, 0, "") { }

        public void Deposit(double amount) 
        {
            if (amount > 0) 
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount:F2}. Balance: ${balance:F2}");
            }
            else
                Console.WriteLine("Deposit must be positive.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance) 
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount:F2}. Balance: ${balance:F2}");
            }
            else
                Console.WriteLine("Insufficient funds.");
        }

        public void PrintSummary()
        {
            Console.WriteLine($"\n--- Account Summary ---");
            Console.WriteLine($"Owner:   {owner}");
            Console.WriteLine($"Type:    {accountType}");
            Console.WriteLine($"Balance: ${balance:F2}");
            Console.WriteLine($"-----------------------\n");
        }
    }
}
