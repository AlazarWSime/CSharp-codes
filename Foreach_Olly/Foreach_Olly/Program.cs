using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Olly
{
    internal class Program

    {
        static void Name(int[] arr) {
            foreach (int i in arr) {
             Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 11, 4, 20, 9, 2, 8 };
            Name(arr);

        }
    }
}
