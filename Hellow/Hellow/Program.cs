using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hellow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hellow World!");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Clear(); // Clear the console to apply the background color to the entire window

            //int x, y;
            //x = 10;
            //y = 20;

            //Console.WriteLine($"{x} + {y} is {x+y}");

            //int test;
            //Console.WriteLine("Enter an integer");
            //test = Console.Read();
            //Console.WriteLine($"You Entered: {test}"); // when you hit inter it's gone output the ASCII value of the key you hit, not the numebr it self

            //test = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Accepted {test}");

            //int[] arr = new int[5];
            //int[,] _2D = new int[2,3];
            //try {
            //    checked{
            //        sbyte test2 = -128; // -128 to 127
            //        test2--;

            //        Console.WriteLine(test2);
            //    }
            //} catch {

            //    Console.WriteLine("hellow, the number you have intered is overflow");
            //}
            //int test = 5;
            //int[] numbers = new int[test];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            int[][] jaggedArray = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 },
                new int[] {}
            };

            Console.WriteLine("Jagged Array:");
            Console.WriteLine(jaggedArray[0][0]);
            Console.WriteLine(jaggedArray[0][2]);
            Console.WriteLine(jaggedArray[1][0]);
            Console.WriteLine(jaggedArray[2][0]);

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
             

            }

            int[][] jaggedArray1 = new int[3][]
{
           new int[] { 1, 2, 3 },
            new int[] {4, 5},
             new int[] {6, 7, 8, 9}
};

Console.WriteLine(jaggedArray);
            Console.WriteLine("jaggedArray2");
            int[][] jaggedArray2 = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] {4, 5},
            new int[] {6, 7, 8,}
    };
            for (int arra = 0; arra < jaggedArray2.Length; arra++)
            {
                Console.WriteLine("index"+ arra);
                for(int arraa = 0; arraa < jaggedArray2[arra].Length; arraa++)
                {
                    Console.WriteLine(jaggedArray2[arra][arraa]);
                }
            }
        }
    }
}
