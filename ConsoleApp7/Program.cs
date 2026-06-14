using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    static class Converter
    {
        public static double KmToMiles(double km)
        {
            return km * 0.621371;
        }

        public static double MilesToKm(double miles)
        {
            return miles / 0.621371;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

    class Printer
    {
        // This method accepts a Car object and prints its details
        public void PrintCarDetails(Car car)
        {
            Console.WriteLine($"Printing details for: {car.Make}");
        }
    }

    class Car
    {
        public string Make { get; private set; }
        private Printer printer;

        public Car(string make)
        {
            Make = make;
            printer = new Printer();
        }

        public void SendToPrinter()
        {
            // Passing 'this' (the current Car object) to the Printer
            printer.PrintCarDetails(this);
        } 
    }
    internal class Program
    {
        static void Main(string []args)
            {


            Car myCar = new Car("Toyota");
            myCar.SendToPrinter();
                
                
                
                int[] values = { 10, 20, 30, 40 };

            Console.WriteLine(Converter.FahrenheitToCelsius(0));
            
            BankAccount acc1 = new BankAccount("Alazar", 1000.00, "Checking");
        acc1.Deposit(500);
        acc1.Withdraw(200);
        acc1.PrintSummary();

        // Using constructor 2
        BankAccount acc2 = new BankAccount("Dawit", "Business");
        acc2.Deposit(2000);
        acc2.PrintSummary();

        // Using constructor 3
        BankAccount acc3 = new BankAccount("Sara");
        acc3.Deposit(300);
        acc3.PrintSummary();

            BankAccount acc = new BankAccount("Alazar", 1000.00, "Checking");



            // ❌ All blocked — data is protected
            // acc.balance = -9999;     // COMPILER ERROR — private
            // acc.owner = "";           // COMPILER ERROR — private setter
            // acc.accountNumber = "X";  // COMPILER ERROR — private


            Student s1 = new Student("Alazar", 22, 3.8, "Computer Science");
            Student s2 = new Student("Dawit", "Engineering");
            Student s3 = new Student("Sara");

            s1.PrintInfo();
            s2.PrintInfo();
            s3.PrintInfo();

            // Method chaining using 'this'
            s2.UpdateGPA(3.5).UpdateMajor("Software Engineering");
            s2.PrintInfo();

            // Passing 'this' to another object
            CourseRegistrar registrar = new CourseRegistrar();
            s1.RegisterForCourse(registrar);
        }

    }

   

class Student
    {
        // Private fields
        private string name;
        private int age;
        private double gpa;
        private string major;

        // Properties
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public double GPA { get { return gpa; } }
        public string Major { get { return major; } }

        // Use 1: 'this' resolves name conflict in constructor
        public Student(string name, int age, double gpa, string major)
        {
            this.name = name;
            this.age = age;
            this.gpa = gpa;
            this.major = major;
        }

        // Use 4: Constructor chaining with this()
        public Student(string name, string major)
            : this(name, 18, 0.0, major)
        {
        }

        public Student(string name)
            : this(name, "Undeclared")
        {
        }

        // Use 2: Calling class methods with this
        private bool IsHonorsStudent() => this.gpa >= 3.7;
        

        private string GetStanding()
        {
            if (this.gpa >= 3.7) return "Honors";
            else if (this.gpa >= 3.0) return "Good Standing";
            else if (this.gpa >= 2.0) return "Satisfactory";
            else return "Academic Probation";
        }

        // Use 3: Passing 'this' to another method
        public void RegisterForCourse(CourseRegistrar registrar)
        {
            registrar.Register(this); // passing current student object
        }

        // Use 5: Returning 'this' for method chaining
        public Student UpdateGPA(double newGpa)
        {
            if (newGpa >= 0.0 && newGpa <= 4.0)
                this.gpa = newGpa;
            else
                Console.WriteLine("GPA must be between 0.0 and 4.0");
            return this;
        }

        public Student UpdateMajor(string newMajor)
        {
            this.major = newMajor;
            return this;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\n=== Student Record ===");
            Console.WriteLine($"Name:     {this.name}");
            Console.WriteLine($"Age:      {this.age}");
            Console.WriteLine($"Major:    {this.major}");
            Console.WriteLine($"GPA:      {this.gpa:F2}");
            Console.WriteLine($"Standing: {this.GetStanding()}");
            Console.WriteLine($"Honors:   {(this.IsHonorsStudent() ? "Yes" : "No")}");
            Console.WriteLine($"======================\n");
        }
    }

    class CourseRegistrar
    {
        public void Register(Student student)
        {
            Console.WriteLine($"Registering {student.Name} " +
                              $"(Major: {student.Major}) for courses...");
        }
    }

   
            // Constructor chaining
           
        
}
