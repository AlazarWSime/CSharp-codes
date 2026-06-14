using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Person
    {
        // Private backing field — hidden from outside
        private int age;

        // Public property — the controlled gateway
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 150)
                    age = value;
                else
                    Console.WriteLine("Invalid age! Must be between 0 and 150.");
            }
        }

        public int[] array = new int[10];
        public string str;
    }
}
