using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Drived : Original
    {
        public char testChar { set; get; }
        public double testDouble { set; get; }
        public bool testBool { set; get; }

        public Drived(int tInt, float tfloat, string tString, char tChar, double tDouble, bool tBool) 
        : base( ) 
            // when using parent class constructor the base constructor AKA the parent master constructor should include it's parameter with out it's types
            //the base's role is to make us able to acces a specific constructor 
            //the drived class constructor must be able to have all the parameter to be used includes the parents para
        {
            testChar = tChar; 
            testDouble = tDouble; 
            testBool = tBool;
            
        }

        public Drived() { } // when there is a 1 or above argument constructor in the class by defold it's gone change the name defult construct by then new explicti 1+ arugnment constructor. 
        public void DisplayAll() 
        {
            Console.WriteLine(testint);
            Console.WriteLine(testfloat);
            Console.WriteLine(testString);
            Console.WriteLine(testChar);
            Console.WriteLine(testDouble);
            Console.WriteLine(testBool);
            
        }
    }
} 
