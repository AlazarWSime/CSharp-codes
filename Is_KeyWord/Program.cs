using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Is_KeyWord
{

    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Make} {Model}");
        }
    }

    public class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string make, string model, int doors) : base(make, model)
        {
            Doors = doors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Type: Car | Doors: {Doors}");
        }

        public void Honk() => Console.WriteLine("Beep! Beep!");
    }

    public class SportsCar : Vehicle
    {
        public bool HasTurbo { get; set; }

        public SportsCar(string make, string model, bool hasTurbo) : base(make, model)
        {
            HasTurbo = hasTurbo;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"   Type: SportsCar | Turbo: {HasTurbo}");
        }

        public void TurboBoost() => Console.WriteLine("💨 Turbo Boost Activated!");
    }

    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }

        public Truck(string make, string model, int capacity) : base(make, model)
        {
            CargoCapacity = capacity;
        }

        public void LoadCargo() => Console.WriteLine($"Loading {CargoCapacity} tons of cargo...");
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Runtime Type Checking ===\n");

            Vehicle[] vehicles = new Vehicle[]
            {
            new Car("Toyota", "Camry", 4),
            new SportsCar("Ferrari", "488", true),
            new Truck("Volvo", "FH16", 25),
            new Car("Honda", "Civic", 2)
            };

            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();

                // Technique 1: GetType()
                Console.WriteLine($"   Actual Type: {v.GetType().Name}");

                // Technique 2: is + pattern matching (Best modern approach)
                if (v is SportsCar sc)
                {
                    sc.TurboBoost();
                }
                else if (v is Truck t)
                {
                    t.LoadCargo();
                }
                else if (v is Car c)
                {
                    c.Honk();
                }

                Console.WriteLine("   -----------------------------");
            }

            // Technique 3: as operator
            Console.WriteLine("\n=== Using 'as' Operator ===");
            Vehicle test = new SportsCar("Lamborghini", "Huracan", true);
            SportsCar sports = test as SportsCar;

            if (sports != null)
            {
                Console.WriteLine("Successfully cast to SportsCar using 'as'");
                sports.TurboBoost();
            }

            // Technique 4: typeof()
            if (test.GetType() == typeof(SportsCar))
            {
                Console.WriteLine("Exact type match using typeof()");
            }
        }
    }
}
