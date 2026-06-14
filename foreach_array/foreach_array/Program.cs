using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace foreach_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            Random rand = new Random();
            int count = 0;
           

            foreach (int[] inner in jagged)
            {
                jagged[count] = new int[(2 + count) * 2];

                int iterate = 0;
                foreach (int j in jagged[count])
                {
                    jagged[count][iterate] = rand.Next(1, 100);
                    iterate++;
                }
                count++;
            }

            foreach (int[] inner in jagged)
            {
                foreach (int item in inner) {
                    Console.Write(item+ " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
