using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Enum_ETDayOFWeeks
{
    internal class Program
    {
        enum ETDayOfWeeks
        {
            Segho, 
            Maksegno, 
            Erob, 
            Hamus, 
            Arb, 
            Qdame,
            Ehud
        }

        static ETDayOfWeeks CalcualteDate(ETDayOfWeeks Date, int offSet)
        {
            ETDayOfWeeks newDay = Date + offSet;
            int totalDay = 7;
            while (newDay < 0 || (int)newDay > 6 ) {
                if (newDay < 0)
                {
                    newDay += totalDay;
                }
                else
                {
                    newDay -= totalDay;
                }
            }

            return newDay;

        }


        static void Main(string[] args)
        {
            Console.WriteLine(CalcualteDate(ETDayOfWeeks.Ehud, 10));
        }
    }
}
