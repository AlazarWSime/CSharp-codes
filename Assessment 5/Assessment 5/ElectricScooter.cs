using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5
{
    internal class ElectricScooter : Vehicle
    {
        public ElectricScooter(string m, int y) : base(m, y) { }
        public override void StartEngine() 
        {
            Console.WriteLine("Scooter powered on.");
        }

        public new string Describe() 
        {
            return ($"Electric Scooter: {model} {year}");
        }

    }
}
