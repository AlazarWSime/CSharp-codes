using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][]; // the delaration on jagged array
            for (int i = 0; i<jaggedArray.Length; i++)
            {
                int innerArray = (i * 3) + 2;
                jaggedArray[i] = new int[innerArray];

            }

            for (int i = 0; i<jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Enter the arra [{i}][{j}]: ");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "");

                }
                Console.WriteLine();

            }

            
        }

    }
}