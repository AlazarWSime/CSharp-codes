using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct
{
    internal class Car : Vehicle
    {
        public override void move() 
        {
            Console.WriteLine("Car is moving on road ");
        }
    }
}
