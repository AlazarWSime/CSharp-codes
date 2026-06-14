using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Right_angle_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[6][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int innerArray;
                if (i > 1)
                {
                     innerArray = i;
                }
                else
                {
                     innerArray = 1; // this one is the size of the inner array not the index of the inner arrar
                }
                jaggedArray[i] = new int[innerArray];
            }

            for (int i = 0; i < jaggedArray.Length ; i++) {
               for(int j=0; j < jaggedArray[i].Length;j++)
                {
                   
                    jaggedArray[i][j] = i;
                    Console.Write(jaggedArray[i][j]);
                }
               Console.WriteLine();
            }
        }
    }
}
