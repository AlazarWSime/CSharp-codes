using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct
{
    abstract class Vehicle

    {
        public void start() 
        {
            Console.WriteLine("The car is staritng....");
        }

        public abstract void move();
        //abstract methods doesn't have a body
        //it is lafet declared with a key word "abstruct"
    }
}
