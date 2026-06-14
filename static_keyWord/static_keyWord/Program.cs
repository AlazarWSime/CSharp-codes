using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace static_keyWord
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //traditional getter and setter function envoking
            testCls obj = new testCls();
            obj.set_floatTest(3.14f);
            Console.WriteLine(obj.get_floatTest());
            int x;
            float y;
            char c;
            string f;
             
            //using property as a getter and setter
            testCls obj1 = new testCls();
            obj.TestInt = 8; // getter
            Console.WriteLine(obj1.TestInt); // setter
            obj1.testMethod();// accessing a normal method form a class



            //Compiler error! WriteLine() is not an object level method!
            //Console C = new Console();
            //C.WrtieLine("It can't be printed...");

            //instead simply prefix the class name to the static WriteLine() member.
            //Correct! WriteLine() is a static method.
            //Console.WriteLine("Much better! Thanks...");

            //trying to acces a static field form the class 
            testCls obj2 = new testCls();
            //obj2.testInt = 1;
            //Error! Member 'testCls.testInt' cannot be accessed with an instace reference; qualify it with a type name instead


            //trying to acces a static constructor from the class
            testCls obj3 = new testCls();
            //Error There is no argument given that corresponds to the requiered paramenter 'testFloat' of 'testCls.testCls(int)'
        }
    }
}
//make a field static see the output
//make the constructor a static
//make the method static 
// make the whole class static 