using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachL
{
    internal class Program
    {
        
            static bool IsInertial(int[] arr, out int sum, out string msg)
            {
                int max = arr.Max();
                bool isodd = false;

                int largestOdd = int.MaxValue;
                int largestEven = 0;

                foreach (int n in arr)
                {
                    if (n % 2 == 0)
                    {
                        if (n > largestEven)
                            largestEven = n;
                    }
                }


                if (largestEven % 2 != 0)
                {
                    sum = 0;
                    msg = "Not Inertial";
                    return false;
                }


                foreach (int n in arr)
                {
                    if (n % 2 != 0)
                    {
                        isodd = true;

                        if (n > largestOdd)
                            largestOdd = n;
                    }
                }


                if (!isodd)
                {
                    sum = 0;
                    msg = "Not Inertial";
                    return false;
                }


                foreach (int odd in arr)
                {
                    if (odd % 2 != 0)
                    {
                        foreach (int even in arr)
                        {
                            if (even % 2 == 0 && even != max)
                            {
                                if (odd <= even)
                                {
                                    sum = 0;
                                      msg = "Not Inertial";
                                    return false;
                                }
                            }
                        }
                    }
                }


                sum = largestOdd + largestEven;
                msg = "Inertial";
                return true;
            }

            static void Main(string[] args)
            {
                int[] arr = { 11, 4, 20, 9, 2, 8 };

                int sum;
                string msg;

                bool result = IsInertial(arr, out sum, out msg);

                Console.WriteLine("Array Elements:");
                foreach (int n in arr)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine("\nResult: " + msg);
                Console.WriteLine("Sum: " + sum);

                Console.ReadKey();
            }
        }
    }
