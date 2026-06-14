using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle(string m, int y) : base(m, y) { }
        public override void StartEngine() 
        {
            Console.WriteLine("Motorcycle Engine started...");
        }

        public override void Move()
        {
            Console.WriteLine("Motorcycle is speeding ahead...");
        }
        public void PopWheelie() 
        {
            Console.WriteLine("Popping Wheelie!");
        }

    }
}
