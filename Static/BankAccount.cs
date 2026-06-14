using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class BankAccount
    {
        // Instance variables — unique per account
        private string owner;
        private double balance;
        private string accountId;

        // Static variables — shared across ALL accounts
        private static int totalAccounts = 0;
        private static double totalDepositsAllAccounts = 0;
        private static double interestRate = 0.035; // 3.5% for all accounts

        // Properties
        public string Owner { get { return owner; } }
        public double Balance { get { return balance; } }
        public string AccountId { get { return accountId; } }

        // Static properties
        public static int TotalAccounts
        {
            get { return totalAccounts; }
        }

        public static double InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value >= 0 && value <= 1)
                    interestRate = value;
                else
                    Console.WriteLine("Interest rate must be between 0 and 1.");
            }
        }

        // Constructor — updates static counter each time
        public BankAccount(string owner, double initialDeposit)
        {
            totalAccounts++;
            accountId = $"ACC-{totalAccounts:D4}"; // ACC-0001, ACC-0002...

            this.owner = owner;

            if (initialDeposit >= 0)
            {
                balance = initialDeposit;
                totalDepositsAllAccounts += initialDeposit;
            }
            else
            {
                Console.WriteLine("Initial deposit cannot be negative.");
                balance = 0;
            }
        }

        // Instance method — affects only this account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                totalDepositsAllAccounts += amount; // updates shared static
                Console.WriteLine($"[{accountId}] Deposited ${amount:F2}. " +
                                  $"Balance: ${balance:F2}");
            }
        }

        // Instance method — applies interest to this account
        public void ApplyInterest()
        {
            double interest = balance * interestRate;
            balance += interest;
            Console.WriteLine($"[{accountId}] Interest applied: ${interest:F2}. " +
                              $"New balance: ${balance:F2}");
        }

        // Static method — reports on ALL accounts
        public static void PrintBankSummary()
        {
            Console.WriteLine($"\n===== Bank Summary =====");
            Console.WriteLine($"Total Accounts:       {totalAccounts}");
            Console.WriteLine($"Total Deposits:       ${totalDepositsAllAccounts:F2}");
            Console.WriteLine($"Current Interest Rate:{interestRate * 100:F1}%");
            Console.WriteLine($"========================\n");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"[{accountId}] Owner: {owner}, " +
                              $"Balance: ${balance:F2}");
        }
    }
}
