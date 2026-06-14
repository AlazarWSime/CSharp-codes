using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            //Console.WriteLine(add(ref a,b));
            Console.WriteLine(OutRefParams(out a, out b));


            //int[] arr = new int[] { 1, 2, 3 };

            //int[] NewArr = arr;

            //for (int i = 0; i< NewArr.Length; i++)
            //{
            //    Console.Write(NewArr[i]+ ",");
            //}
        }

       static int OutRefParams(out int x, out int y)
        {
             x = 0;
             y = 0;

            int z = ++x + ++y;
            return z;
       }


        //<return type><name>(<parameter>)
        static int add(ref int x,int y)
        {
            int z = ++x + ++y;
            return z;
        }
    }
}
