using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        enum DeviceFeature
        {
            read,
            write, 
            delete, 
            update
        }
        static void Main(string[] args)
        {
            DeviceFeature Permission;
            switch (Permission)
            {
                case 1:
                    Console.WriteLine();
            }
        }
    }
}
