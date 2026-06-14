using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{ 
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Drived dObj = new Drived();
            Console.WriteLine(dObj.testChar);
            Console.WriteLine(dObj.testint);
            Console.WriteLine(dObj.testfloat);
            //Console.WriteLine(dObj.testString);//access modifier was protected
            Console.WriteLine(dObj.testDouble);
            Console.WriteLine(dObj.testBool);
           
        }
    }
}
