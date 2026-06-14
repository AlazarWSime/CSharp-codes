using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haile
{
    class Program
    {
        // Method 
        static bool IsInertial(int[] arr, out int sum, out string text)
        {
            sum = 0;
            text = "not inertial";

            if (arr.Length < 2) return false;

            int max = arr[0];
            bool hasOdd = false;

            //  A: Check at least one odd 
            foreach (int n in arr)
            {
                if (n % 2 != 0) hasOdd = true;
                if (n > max) max = n; // also find max
            }

            arr.Max();
            if (!hasOdd) return false; 

            //B: Check if max is even 
            if (max % 2 != 0) return false; 

            // C: Check every odd > every even except max 
            int largestOdd = 0;
            int largestEven = 0;
            foreach (int n in arr)
            {
                if (n % 2 != 0 && n > largestOdd) largestOdd = n; // largest odd
                if (n % 2 == 0 && n != max && n > largestEven) largestEven = n; // largest even except max
            }

            foreach (int n in arr)
            {
                if (n % 2 != 0 && n <= largestEven) return false; 
            }

            
            sum = largestOdd + max;
            text = "inertial";
            return true;
        }

        static void Main()
        {
            int[] arr = { 11, 4, 20, 9, 2, 8 }; 

            // Call the method
            bool result = IsInertial(arr, out int sum, out string text);

            // Display array
            Console.Write("Array elements: ");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // Display results
            Console.WriteLine("Result: " + text);
            Console.WriteLine("Sum of largest odd and largest even: " + sum);
            Console.ReadKey(); 
        }
    }
}
