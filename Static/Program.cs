using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Animal
    {
        private string animalName { get; set; }
        private int age { get; set; }
        private string name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a generic sound.");
        }

        protected Animal(string name, string animalName, int age)
        {
            this.name = name;
            this.animalName = animalName;
            this.age = age;
        }
        protected Animal() { }
    }

    public class Dog : Animal
    {
        public string Breed { get; set; }
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine(" yabadabadu ");
        }
        public Dog(string name, string animalName, int age, string Breed) : base(name, animalName,age) 
        {
            this.Breed = Breed;
            Console.WriteLine("Dog constructor called. ");
        }
        public Dog() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog dog = new Dog();
            dog.Speak();

            Dog dog1 = new Dog("guffi", "jasper", 3, "shepered");


            //// No accounts yet
            //BankAccount.PrintBankSummary();

            //// Create accounts — static counter updates each time
            //BankAccount acc1 = new BankAccount("Alazar", 1000);
            //BankAccount acc2 = new BankAccount("Dawit", 2500);
            //BankAccount acc3 = new BankAccount("Sara", 500);

            //BankAccount.PrintBankSummary();

            //// Instance operations
            //acc1.Deposit(500);
            //acc2.Deposit(1000);

            //// Apply interest to each account individually
            //acc1.ApplyInterest();
            //acc2.ApplyInterest();
            //acc3.ApplyInterest();

            //Console.WriteLine();
            //acc1.PrintInfo();
            //acc2.PrintInfo();
            //acc3.PrintInfo();

            //// Change interest rate for ALL accounts at once
            //Console.WriteLine("\nChanging interest rate to 5%...");
            //BankAccount.InterestRate = 0.05;

            //BankAccount.PrintBankSummary();

        }
    }
}
