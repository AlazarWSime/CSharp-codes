using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Original
    {
        public int testint { get; protected set; }
        public float testfloat {  get; private set; }
        protected string testString {  get; set; }

        public Original(int tInt, float tfloat, string tString)
        {
            testint = tInt;
            testfloat = tfloat;
            testString = tString;
        }

        public Original(int tInt,  string tString):this(tInt, 0.0f, tString)
        {
          
        }
        protected Original() { }

        public Original(int INT): this(INT, 0.0f, null) 
        {
          //the benefit of constructor chaining is: if the instance are initalized in a master constructer
          //we don't have to right a sing constructor to for each instances to access a class if we want
          //to access only one or two instance at a time
        }
    }
}
//the relation ship between constructor chaing and inheritance is they bothe make us able to access 
// partet class or parten constructure from a chiled class or constructor