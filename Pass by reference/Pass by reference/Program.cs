using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_reference
{
    class Program
    {

       public void Swap( ref int x, int y)// pass by value
         {
            int temp = x;
            x = y;
            
            
            y = temp;
        }
        static void Main(string[] args)
        {
            //void ChangeValue(ref int x)
            //{
            //    x = 100;
            //}
            //int num = 10;
            //ChangeValue(ref num);
            //Console.WriteLine(num); // Output: 100

            void GetSum( out int sum)
            {
                sum = 100; // must assign
            }

            int result = 10; // not initialized
            GetSum(out result);

            Console.WriteLine(result); // Output: 12
            int t = 3;
            int z = 5;
            Console.WriteLine($"Valuse before swap {t}, {z}");
             Swap(ref t, z);
            Console.WriteLine($"Valuse after swap {t}, {z}" );

            void Change(ref int x)
{
    x = 100;
}

int a = 10;
Change(ref a);

Console.WriteLine(a); 
        }
    }
    
        
}
