using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace foreeach_Redo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            Random rand = new Random();
            int Count = 0;
            foreach (int[] outer in jagged )
            {
                jagged[Count] = new int[(Count + 2) * 2];
                int inner_Count = 0;
                foreach(int inner in jagged[Count])
                {
                    jagged[Count][inner_Count] = rand.Next(1, 200);
                    inner_Count++;
                }
                Count++;
            }

            foreach (int[] outer in jagged)
            {
                foreach(int inner in outer)
                {
                   Console.Write(inner+ " ");

                }
                Console.WriteLine();
            }
        }
    }
}