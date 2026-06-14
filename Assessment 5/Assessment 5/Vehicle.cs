using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5
{
    public abstract class Vehicle
    {
        public String model { set; get; }
        public int year { set; get; }

        public Vehicle() { }
        public Vehicle(String Mod, int Year)
        {
            model = Mod;
            year = Year;
        }
        public abstract void StartEngine();

        public virtual void Move()
        {
            Console.WriteLine("The Vehicle is moving ");
        }

        public virtual String Describe()
        {
            return( $" Vehicle: {model} {year}");
        }
    }
}
