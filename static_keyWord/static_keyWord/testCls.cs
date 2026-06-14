using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyWord
{
    class testCls
    {
        public static int testInt {  get; set; }
        float testFloat { get; set; }
        char TestChar { get; set; } //Autho property

        //defoult Constructor
        static testCls()
        {
            Console.WriteLine("i am accessable while am im a static constructor");
        }

        //constructor with a parameter
         //public testCls(int testFloat)
        //{
        //    this.testFloat = testFloat;
        //}



        //method
        public int testMethod()
        {
            return TestChar;
        }
        //property
       public int TestInt {
            get { return testInt; }
            set 
            {
                if(testInt > 3)
                  testInt = value; 
            }
        }
        //get set method
        public void set_floatTest(float testFloat)
        {
            this.testFloat = testFloat;

        }

        public float get_floatTest()
        {
            return testFloat;
        }

    }
}
