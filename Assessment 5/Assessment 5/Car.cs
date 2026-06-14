using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5
{
    internal class Car : Vehicle
    {
        
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started");
        }

        public override void Move()
        {
            Console.WriteLine("Car is driving on the road");
        }

        public override string Describe()
        {
            return ($"Car: {model} {year}");
        }

        public void OppenTrunk() 
        {
            Console.WriteLine("Oppening Trunk...");
        }

        public Car(string m, int y) : base(m, y) 
        {
            
        }
    }
}
